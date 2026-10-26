/*
 * Author: Thys Fourie
 * Date: 2026-02-27
 * Purpose: Application entry point. Starts the animated splash screen then the StartForm.
 */

using System;
using System.Windows.Forms;
using EduvosOnboardingGame.UI;

namespace EduvosOnboardingGame
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var splash = new SplashForm())
            {
                splash.ShowDialog();
            }

            Application.Run(new StartForm());
        }
    }
}
