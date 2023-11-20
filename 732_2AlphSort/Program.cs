namespace _732_2AlphSort
{
    internal static class Program
    {
        private static DBManager dbmanager = new DBManager("D:\\creds.db");

        private static MainForm mainForm = new MainForm();
        private static authForm authform = new authForm(mainForm, dbmanager);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            authform.Show();

            Application.Run(mainForm);

        }
    }
}