/*
 * Author: Thys Fourie
 * Date: 2026-02-22
 * Purpose: Abstract base class for daily scenarios. Each subclass describes the day's scenario and applies updates
 *          to the Student object when an option is selected.
 */

using EduvosOnboardingGame.Models;

namespace EduvosOnboardingGame.Scenarios
{
    public enum ScenarioChoice
    {
        Option1 = 1,
        Option2 = 2
    }

    public abstract class DailyScenario
    {
        public abstract string Description { get; }
        public abstract string Option1Text { get; }
        public abstract string Option2Text { get; }

        /// <summary>
        /// Applies the scenario logic to the student based on the chosen option.
        /// </summary>
        public abstract void Execute(Student student, ScenarioChoice choice);
    }
}
