/*
 * Author: Thys Fourie
 * Date: 2026-02-17
 * Purpose: Collects and validates the student's name using regex, then starts the game.
 */

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EduvosOnboardingGame.Models;

namespace EduvosOnboardingGame.UI
{
    public partial class StartForm : Form
    {
        // Letters only (allows spaces/hyphens between names).
        private readonly Regex _nameRegex = new Regex(@"^[A-Za-z]+(?:[ -][A-Za-z]+)*$");

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();

                if (!_nameRegex.IsMatch(name))
                {
                    errorProvider.SetError(txtName, "Please enter a valid name (letters only).");
                    txtName.Focus();
                    return;
                }

                errorProvider.SetError(txtName, string.Empty);

                Student student = new Student(name);

                Hide();
                using (var gameForm = new GameForm(student))
                {
                    gameForm.ShowDialog();
                }
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while starting the game.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
