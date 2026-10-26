/*
 * Author: Thys Fourie
 * Date: 2026-03-01
 * Purpose: Day 3 - Study vs Socialise scenario.
 */

using EduvosOnboardingGame.Models;

namespace EduvosOnboardingGame.Scenarios
{
    public class StudyScenario : DailyScenario
    {
        public override string Description => "Study vs Socialise: You have free time. Do you study or socialise?";
        public override string Option1Text => "Study (+20 Knowledge, -20 Energy)";
        public override string Option2Text => "Socialise (+5 Motivation, -10 Energy)";

        public override void Execute(Student student, ScenarioChoice choice)
        {
            if (choice == ScenarioChoice.Option1)
            {
                student.UpdateKnowledge(+20);
                student.UpdateEnergy(-20);
            }
            else
            {
                student.UpdateMotivation(+5);
                student.UpdateEnergy(-10);
            }
        }
    }
}
