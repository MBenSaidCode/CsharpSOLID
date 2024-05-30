namespace OCP.Abstractions
{
    /// <summary>
    /// Represents a bonus calculator interface
    /// </summary>
    public interface IBonusCalculator
    {
        /// <summary>
        /// Calculates the bonus based on the provided base salary
        /// </summary>
        /// <param name="baseSalary">The base salary</param>
        /// <returns>The calculated bonus</returns>
        double CalculateBonus(double baseSalary);
    }
}