using OCP.Abstractions;

namespace OCP.BonusCalculators
{
    /// <summary>
    /// Represents a bonus calculator for engineers
    /// </summary>
    public class EngineerBonusCalculator : IBonusCalculator
    {
        /// <summary>
        /// Calculates the bonus for an engineer based on the base salary
        /// </summary>
        /// <param name="baseSalary">The base salary of the engineer</param>
        /// <returns>The calculated bonus amount</returns>
        public double CalculateBonus(double baseSalary)
        {
             return baseSalary * BonusPercentageConstants.EngineerBonusPercentage;
        }
    }
}