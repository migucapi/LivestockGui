using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LivestockGui
{
    public partial class FrmRemoveAnimal : Form
    {


        // Constructor
        private FarmManager farmManager;
        public FrmRemoveAnimal(FarmManager farmManager)
        {
            InitializeComponent();
            this.farmManager = farmManager;
            PopulateAnimalDropdown();

        }

        // Fills choose animal combobox
        private void PopulateAnimalDropdown()
        {
            cbxChooseAnimal.Items.Clear();
            foreach (Animal animal in farmManager.GetAllAnimals())
                cbxChooseAnimal.Items.Add(animal.AnimalSummary());
        }


        // Buttons
        // Homepage Button
        private void btnHomepage_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form

        }

        // Remove Animal Button
        private void btnRemoveAnimal_Click(object sender, EventArgs e)
        {
            if (cbxChooseAnimal.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an animal to remove.", "No Animal Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // extract ID from selected summary string
            string selected = cbxChooseAnimal.SelectedItem.ToString();
            string id = selected.Split('|')[0].Trim();

            // confirm before removing
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to remove this animal?",
                "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                farmManager.RemoveAnimal(id);
                MessageBox.Show("Animal removed.", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateAnimalDropdown();
            }
        }
    }
}
