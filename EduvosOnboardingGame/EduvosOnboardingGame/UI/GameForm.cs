/*
 * Author: Thys Fourie
 * Date: 2026-02-17
 * Purpose: Main game loop (Days 1-5). Displays scenarios and updates student statistics.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EduvosOnboardingGame.Models;
using EduvosOnboardingGame.Scenarios;

namespace EduvosOnboardingGame.UI
{
    public partial class GameForm : Form
    {
        private readonly Student _student;
        private readonly List<DailyScenario> _scenarios;
        private int _currentDayIndex;

        public GameForm(Student student)
        {
            _student = student ?? throw new ArgumentNullException(nameof(student));
            _scenarios = BuildScenarioList();

            InitializeComponent();
            LoadDay(0);
        }

        private static List<DailyScenario> BuildScenarioList()
        {
            // Scenarios stored in a List (as required).
            return new List<DailyScenario>
            {
                new OrientationScenario(),
                new LectureScenario(),
                new StudyScenario(),
                new AssignmentScenario(),
                new QuizScenario()
            };
        }

        private void LoadDay(int dayIndex)
        {
            _currentDayIndex = dayIndex;

            // Switch statement demonstration (day selection).
            switch (dayIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    DailyScenario scenario = _scenarios[dayIndex];
                    lblDay.Text = $"Day {dayIndex + 1} of 5";
                    lblStudentName.Text = $"Student: {_student.Name}";
                    lblScenario.Text = scenario.Description;
                    btnOption1.Text = scenario.Option1Text;
                    btnOption2.Text = scenario.Option2Text;
                    UpdateStatsUI();
                    break;

                default:
                    ShowResult(false);
                    break;
            }
        }

        private void btnOption1_Click(object sender, EventArgs e) => HandleChoice(ScenarioChoice.Option1);
        private void btnOption2_Click(object sender, EventArgs e) => HandleChoice(ScenarioChoice.Option2);

        private void HandleChoice(ScenarioChoice choice)
        {
            DailyScenario scenario = _scenarios[_currentDayIndex];

            // Apply the scenario logic.
            scenario.Execute(_student, choice);

            // Visual feedback for low energy.
            UpdateStatsUI();

            // Burnout check (as required).
            if (CheckBurnout())
            {
                ShowResult(true);
                return;
            }

            // Advance day.
            int nextDay = _currentDayIndex + 1;
            if (nextDay >= _scenarios.Count)
            {
                ShowResult(false);
                return;
            }

            LoadDay(nextDay);
        }

        private void UpdateStatsUI()
        {
            lblEnergyValue.Text = _student.Energy.ToString();
            lblKnowledgeValue.Text = _student.Knowledge.ToString();
            lblMotivationValue.Text = _student.Motivation.ToString();

            if (_student.Energy <= 20)
            {
                lblEnergyValue.ForeColor = Color.Orange;
                lblWarning.Text = "Warning: Low energy! Consider choices that prevent burnout.";
                lblWarning.Visible = true;
            }
            else
            {
                lblEnergyValue.ForeColor = Color.White;
                lblWarning.Visible = false;
            }
        }

        private bool CheckBurnout()
        {
            if (_student.Energy <= 10)
            {
                MessageBox.Show("You are burned out! Your energy is too low to continue.",
                    "Burnout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void ShowResult(bool burnedOut)
        {
            Hide();
            using (var resultForm = new ResultForm(_student, burnedOut))
            {
                resultForm.ShowDialog();
            }
            Close();
        }
    }
}
