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
    }
}
