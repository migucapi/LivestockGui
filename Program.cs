namespace LivestockGui
{
    internal static class Program
    {


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            // FarmManager
            FarmManager farmManager = new FarmManager();

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmHomepage(farmManager));
        }



    }
}

