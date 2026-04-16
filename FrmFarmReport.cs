using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LivestockGui
{
    public partial class FrmFarmReport : Form
    {
        private FarmManager farmManager;

        public FrmFarmReport(FarmManager farmManager)
        {
            InitializeComponent();
            this.farmManager = farmManager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            FrmHomepage frmHomePage = new FrmHomepage(farmManager);
            frmHomePage.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 closes
            frmHomePage.Show();
        }
    }
}
