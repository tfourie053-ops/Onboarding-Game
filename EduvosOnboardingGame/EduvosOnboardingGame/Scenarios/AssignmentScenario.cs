/*
 * Author: Thys Fourie
 * Date: 2026-02-28
 * Purpose: Day 4 - Group assignment scenario.
 */

using EduvosOnboardingGame.Models;

namespace EduvosOnboardingGame.Scenarios
{
    public class AssignmentScenario : DailyScenario
    {
        public override string Description => "Group Assignment: You must start the first group assignment.";
        public override string Option1Text => "Work in Group (+15 Knowledge, -10 Energy)";
        public override string Option2Text => "Work Alone (+10 Knowledge, -5 Energy)";

        public override void Execute(Student student, ScenarioChoice choice)
        {
            if (choice == ScenarioChoice.Option1)
            {
                student.UpdateKnowledge(+15);
                student.UpdateEnergy(-10);
            }
            else
            {
                student.UpdateKnowledge(+10);
                student.UpdateEnergy(-5);
            }
        }
    }
}
