using OCP.Abstractions;

namespace OCP.BonusCalculators
{
    /// <summary>
    /// Represents a bonus calculator for the head of product role
    /// </summary>
    public class HeadOfProductBonusCalculator : IBonusCalculator
    {
        /// <summary>
        /// Calculates the bonus for the head of product based on the base salary
        /// </summary>
        /// <param name="baseSalary">The base salary of the head of product</param>
        /// <returns>The calculated bonus amount</returns>
        public double CalculateBonus(double baseSalary)
        {
             return baseSalary * BonusPercentageConstants.HeadOfProductBonusPercentage;
        }
    }
}