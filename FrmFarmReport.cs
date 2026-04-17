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
            GenerateReport();
        }

        private void GenerateReport()
        {
            rtbLivestockReport.Text = farmManager.GetSummaryReport();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form


        }

        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}
