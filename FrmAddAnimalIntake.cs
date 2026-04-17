using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LivestockGui
{
    public partial class FrmAddAnimalIntake : Form
    {

        // Constructor
        private FarmManager farmManager;


        public FrmAddAnimalIntake(FarmManager farmManager)
        {
            InitializeComponent();
            this.farmManager = farmManager;
            PopulateAnimalDropdown();

        }

        private void PopulateAnimalDropdown()
        {
            cbxChooseAnimal.Items.Clear();
            foreach (Animal animal in farmManager.GetAllAnimals())
                cbxChooseAnimal.Items.Add(animal.AnimalSummary());
        }


        // Buttons
        private void btnHomepage_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form


        }

        private void btnSaveAnimalIntake_Click(object sender, EventArgs e)
        {
            // check animal is selected
            if (cbxChooseAnimal.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an animal.", "No Animal Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // get the ID from the selected item
            string selected = cbxChooseAnimal.SelectedItem.ToString();
            string id = selected.Split('|')[0].Trim();

            // put all 7 textboxes into an array so we can loop through them
            TextBox[] boxes = { txbMonday, txbTuesday, txbWednesday, txbThursday, txbFriday, txbSaturday, txbSunday };
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int i = 0; i < 7; i++)
            {
                if (!double.TryParse(boxes[i].Text, out double kg) || kg < 0 || kg > 500)
                {
                    MessageBox.Show($"Invalid value for {days[i]}. Must be a number between 0 and 500.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                farmManager.UpdateDailyFood(id, i, kg);
            }

            // show cost and budget status
            Animal animal = farmManager.GetAnimalById(id);
            if (animal != null)
            {
                string status = animal.CheckBudgetStatus();
                double cost = animal.GetWeeklyCost();
                MessageBox.Show($"Feed data saved!\n\nWeekly Cost: ${cost:F2}\nBudget Status: {status}",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
