/*
 * Author: Thys Fourie
 * Date: 2026-02-26
 * Purpose: Day 1 - Orientation scenario.
 */

using EduvosOnboardingGame.Models;

namespace EduvosOnboardingGame.Scenarios
{
    public class OrientationScenario : DailyScenario
    {
        public override string Description => "Orientation Day: You can attend the campus orientation or skip it.";
        public override string Option1Text => "Attend Orientation (+10 Knowledge, -10 Energy)";
        public override string Option2Text => "Skip Orientation (+5 Energy)";

        public override void Execute(Student student, ScenarioChoice choice)
        {
            if (choice == ScenarioChoice.Option1)
            {
                student.UpdateKnowledge(+10);
                student.UpdateEnergy(-10);
            }
            else
            {
                student.UpdateEnergy(+5);
            }
        }
    }
}
