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


    // Constructor
    public partial class FrmHomepage : Form
    {
        private FarmManager farmManager;

        public FrmHomepage(FarmManager farmManager)
        {
            InitializeComponent();
            this.farmManager = farmManager;
            RefreshAnimalList();
            rtbAnimals.ReadOnly = true;
        }
        
        // Refreshes Animal list when page is opened
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RefreshAnimalList();
        }
        
        // Animal List Refresh
        public void RefreshAnimalList()
        {

            rtbAnimals.Clear();

            foreach (string summary in farmManager.GetAnimalSummaries())
            {
                rtbAnimals.AppendText(summary + Environment.NewLine);
            }
        }


        // Buttons leading to other pages
        // Add Animal Page Button
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            FrmAddAnimal frmAddAnimal = new FrmAddAnimal(farmManager);
            frmAddAnimal.ShowDialog(); 

            RefreshAnimalList(); 

        }

        // Save Animal Intake Page Button
        private void btnRecordAnimalIntake_Click(object sender, EventArgs e)
        {
            FrmAddAnimalIntake frmAddAnimalIntake = new FrmAddAnimalIntake(farmManager);
            frmAddAnimalIntake.ShowDialog();

            RefreshAnimalList();
        }

        // Report Page Button
        private void btnLivestockReport_Click(object sender, EventArgs e)
        {
            FrmFarmReport frmFarmReport = new FrmFarmReport(farmManager);
            frmFarmReport.ShowDialog();

            RefreshAnimalList();
        }

        // Remove Animal Page Button
        private void btnRemoveAnimal_Click(object sender, EventArgs e)
        {
            FrmRemoveAnimal frmRemoveAnimal = new FrmRemoveAnimal(farmManager);
            frmRemoveAnimal.ShowDialog();

            RefreshAnimalList();
        }
    }
}
