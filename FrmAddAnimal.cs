namespace LivestockGui
{
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
            // Hide current form
            this.Hide();

            FrmHomepage frmHomePage = new FrmHomepage(farmManager);
            frmHomePage.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 closes
            frmHomePage.Show();
        }
    }

}

