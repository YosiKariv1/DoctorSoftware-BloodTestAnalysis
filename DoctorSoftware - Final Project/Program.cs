namespace DoctorSoftware
{
    internal static class Program
    {
        public static bool LoginPageClosed = false;
        public static bool MenuClosed = true;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new LoginPage());

            if (MenuClosed)
            {
                Application.Run(new Login());
            }

            if (LoginPageClosed)
            {
                Application.Run(new Menu());
            }
        }
    }
}