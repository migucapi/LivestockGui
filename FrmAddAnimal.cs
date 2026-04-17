namespace LivestockGui
{

    // Constructor
    public partial class FrmAddAnimal : Form
    {
        private FarmManager farmManager;


        public FrmAddAnimal(FarmManager farmManager)
        {
            InitializeComponent();
            this.farmManager = farmManager;


        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form
        }

        // Buttons

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            // validate name
            if (string.IsNullOrWhiteSpace(txbAnimalName.Text))
            {
                MessageBox.Show("Please enter an animal name.", "Missing Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validate species selected
            if (cbxSpecies.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a species.", "Missing Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validate food type selected
            if (cbxFoodType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a food type.", "Missing Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validate budget
            if (!double.TryParse(txbWeeklyBudget.Text, out double budget) || budget < 0)
            {
                MessageBox.Show("Please enter a valid weekly budget.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // check farm not full
            if (farmManager.GetAnimalCount() >= farmManager.GetMaxAnimals())
            {
                MessageBox.Show("Farm is full — maximum animals reached.", "Farm Full",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // all valid — add the animal
            string name = txbAnimalName.Text.Trim();
            string species = cbxSpecies.SelectedItem.ToString();
            string food = cbxFoodType.SelectedItem.ToString();


            farmManager.AddAnimal(name, species, food, budget);


            MessageBox.Show($"{name} added successfully!", "Animal Added",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            // clear fields ready for next entry
            txbAnimalName.Text = "";
            txbWeeklyBudget.Text = "";
            cbxSpecies.SelectedIndex = -1;
            cbxFoodType.SelectedIndex = -1;
        }
    }

}

