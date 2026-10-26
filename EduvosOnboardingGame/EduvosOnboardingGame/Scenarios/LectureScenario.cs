/*
 * Author: Thys Fourie
 * Date: 2026-03-03
 * Purpose: Day 2 - First lecture scenario.
 */

using EduvosOnboardingGame.Models;

namespace EduvosOnboardingGame.Scenarios
{
    public class LectureScenario : DailyScenario
    {
        public override string Description => "First Lecture: Your first lecture starts early. Do you go or skip it?";
        public override string Option1Text => "Attend Lecture (+15 Knowledge, -15 Energy)";
        public override string Option2Text => "Skip Lecture (+10 Energy)";

        public override void Execute(Student student, ScenarioChoice choice)
        {
            if (choice == ScenarioChoice.Option1)
            {
                student.UpdateKnowledge(+15);
                student.UpdateEnergy(-15);
            }
            else
            {
                student.UpdateEnergy(+10);
            }
        }
    }
}
