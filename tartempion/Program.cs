namespace tartempion
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
            ApplicationConfiguration.Initialize();
            MonModelMission1.init();
            MonModelMission2.init();
            MonModelMission3.init();
            Application.Run(new FConnexion());
        }
    }
}