using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LivestockGui
{
    public partial class FrmHomepage : Form
    {
        FarmManager farmManager;
        public FrmHomepage(FarmManager farmManager)
        {
            InitializeComponent();
            this.farmManager = farmManager;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            FrmAddAnimal frmAddAnimal = new FrmAddAnimal(farmManager);
            frmAddAnimal.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 closes
            frmAddAnimal.Show();
        }

        private void btnRecordAnimalIntake_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            FrmAddAnimalIntake frmAddAnimalIntake = new FrmAddAnimalIntake(farmManager);
            frmAddAnimalIntake.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 closes
            frmAddAnimalIntake.Show();
        }

        private void btnLivestockReport_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            FrmFarmReport frmFarmReport = new FrmFarmReport(farmManager);
            frmFarmReport.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 closes
            frmFarmReport.Show();
        }

        private void btnRemoveAnimal_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            FrmRemoveAnimal frmRemoveAnimal = new FrmRemoveAnimal(farmManager);
            frmRemoveAnimal.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 closes
            frmRemoveAnimal.Show();
        }
    }
}
