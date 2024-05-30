using OCP.Abstractions;

namespace OCP.BonusCalculators
{
    /// <summary>
    /// Represents a bonus calculator for secretaries
    /// </summary>
    public class SecretaryBonusCalculator : IBonusCalculator
    {
        /// <summary>
        /// Calculates the bonus for a secretary based on the base salary
        /// </summary>
        /// <param name="baseSalary">The base salary of the secretary</param>
        /// <returns>The calculated bonus amount</returns>
        public double CalculateBonus(double baseSalary)
        {
             return baseSalary * BonusPercentageConstants.SecretaryBonusPercentage;
        }
    }
}