/*
 * Author: Thys Fourie
 * Date: 2026-02-17
 * Purpose: Displays the final Knowledge score and performance evaluation message.
 */

using System;
using System.Windows.Forms;
using EduvosOnboardingGame.Models;

namespace EduvosOnboardingGame.UI
{
    public partial class ResultForm : Form
    {
        private readonly Student _student;
        private readonly bool _burnedOut;

        public ResultForm(Student student, bool burnedOut)
        {
            _student = student ?? throw new ArgumentNullException(nameof(student));
            _burnedOut = burnedOut;

            InitializeComponent();
            ShowResults();
        }

        private void ShowResults()
        {
            lblStudent.Text = $"Student: {_student.Name}";
            lblKnowledgeScore.Text = _student.Knowledge.ToString();

            string message;

            if (_burnedOut)
            {
                message = "You burned out before the week was finished. Next time, try managing energy more carefully.";
            }
            else
            {
                // Performance evaluation (as required).
                if (_student.Knowledge <= 40)
                {
                    message = "Performance: Poor. Consider improving your study habits and attending key activities.";
                }
                else if (_student.Knowledge <= 60)
                {
                    message = "Performance: Average. You're doing okay, but a little more consistency will help.";
                }
                else
                {
                    message = "Performance: Excellent! Well done on a productive first week.";
                }
            }

            lblMessage.Text = message;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
