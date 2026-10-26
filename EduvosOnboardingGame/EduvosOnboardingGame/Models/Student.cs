/*
 * Author: Thys Fourie
 * Date: 2026-02-27
 * Purpose: Represents the student/player and stores the current game statistics (Energy, Knowledge, Motivation).
 */

using System;

namespace EduvosOnboardingGame.Models
{
    public class Student
    {
        private readonly string _name;
        private int _energy;
        private int _knowledge;
        private int _motivation;

        public Student(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.", nameof(name));

            _name = name.Trim();

            // Starting values (as per specification).
            _energy = 80;
            _knowledge = 0;
            _motivation = 50;
        }

        // Getters (controlled access)
        public string Name => _name;
        public int Energy => _energy;
        public int Knowledge => _knowledge;
        public int Motivation => _motivation;

        public void UpdateEnergy(int amount) => _energy += amount;
        public void UpdateKnowledge(int amount) => _knowledge += amount;
        public void UpdateMotivation(int amount) => _motivation += amount;

        public string GetStatsString()
        {
            return $"Energy: {Energy}   Knowledge: {Knowledge}   Motivation: {Motivation}";
        }
    }
}
