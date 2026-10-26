/*
 * Author: Thys Fourie
 * Date: 2026-03-01
 * Purpose: Day 5 - Quiz day scenario.
 */

using EduvosOnboardingGame.Models;

namespace EduvosOnboardingGame.Scenarios
{
    public class QuizScenario : DailyScenario
    {
        public override string Description => "Quiz Day: There is a quiz today. How prepared are you?";
        public override string Option1Text => "Well Prepared (+25 Knowledge, -20 Energy)";
        public override string Option2Text => "Poorly Prepared (+10 Knowledge, -10 Energy)";

        public override void Execute(Student student, ScenarioChoice choice)
        {
            if (choice == ScenarioChoice.Option1)
            {
                student.UpdateKnowledge(+25);
                student.UpdateEnergy(-20);
            }
            else
            {
                student.UpdateKnowledge(+10);
                student.UpdateEnergy(-10);
            }
        }
    }
}
