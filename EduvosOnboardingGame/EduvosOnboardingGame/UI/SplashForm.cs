/*
 * Author: Thys Fourie
 * Date: 2026-02-17
 * Purpose: Simple animated splash screen to give the application a professional feel.
 */

using System;
using System.Windows.Forms;

namespace EduvosOnboardingGame.UI
{
    public partial class SplashForm : Form
    {
        private int _ticks;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            _ticks = 0;
            splashTimer.Start();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            _ticks++;

            // Small animation + progress.
            progressLoading.Value = Math.Min(progressLoading.Maximum, _ticks);
            lblLoading.Text = $"Loading... {progressLoading.Value}%";

            if (_ticks >= progressLoading.Maximum)
            {
                splashTimer.Stop();
                Close();
            }
        }
    }
}
