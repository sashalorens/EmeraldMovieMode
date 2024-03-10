using System.Diagnostics;

namespace EmeraldMovieMode
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           TerminateIfAlreadyRunning();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static void TerminateIfAlreadyRunning()
        {
            Process current = Process.GetCurrentProcess();
            if (current == null) return;

            if (Process.GetProcessesByName(current.ProcessName).Length > 1 )
            {
                MessageBox.Show("Application is already running", "EmeraldMovieMode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
        }
    }
}