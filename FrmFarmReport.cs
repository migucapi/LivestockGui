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
        // Constructor
        private FarmManager farmManager;
        public FrmFarmReport(FarmManager farmManager)
        {
            InitializeComponent();
            this.farmManager = farmManager;
            GenerateReport();
        }

        // Generate Report Button
        private void GenerateReport()
        {
            rtbLivestockReport.Text = farmManager.GetSummaryReport();
        }

        // Homepage Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form


        }

        // Refresh report button
        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}
