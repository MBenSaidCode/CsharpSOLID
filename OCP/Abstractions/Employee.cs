
namespace OCP.Abstractions
{
    /// <summary>
    /// Represents an abstract class for an employee
    /// </summary>
    public abstract class Employee
    {
        protected readonly IBonusCalculator BonusCalculator;

        /// <summary>
        /// Gets or sets the unique identifier of the employee
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the full name of the employee
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Gets or sets the base salary of the employee
        /// </summary>
        public double BaseSalary { get; set; }

        /// <summary>
        /// Initializes a new instance of the Employee class with the specified full name, base salary, and bonus calculator
        /// </summary>
        /// <param name="fullName">The full name of the employee</param>
        /// <param name="baseSalary">The base salary of the employee</param>
        /// <param name="bonusCalculator">The bonus calculator used to calculate the bonus</param>
        protected Employee(string fullName, double baseSalary, IBonusCalculator bonusCalculator)
        {
            FullName = fullName;
            BaseSalary = baseSalary;
            BonusCalculator = bonusCalculator;
        }

        /// <summary>
        /// Calculates the bonus for the employee based on the base salary and the bonus calculator
        /// </summary>
        /// <returns>The calculated bonus amount</returns>
        public double CalculateBonus()
        {
            return BonusCalculator.CalculateBonus(BaseSalary);
        }
    }
}