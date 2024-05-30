using OCP.Abstractions;
using System.Collections.Generic;

namespace OCP
{
    /// <summary>
    /// Represents an Engineer employee
    /// </summary>
    public class Engineer : Employee
    {
        /// <summary>
        /// Initializes a new instance of the Engineer class
        /// </summary>
        /// <param name="fullName">The full name of the engineer</param>
        /// <param name="baseSalary">The base salary of the engineer</param>
        /// <param name="bonusCalculator">The bonus calculator for the engineer</param>
        public Engineer(string fullName, double baseSalary, IBonusCalculator bonusCalculator) : base(fullName, baseSalary, bonusCalculator)
        {
        }

        /// <summary>
        /// Gets or sets the programming languages known by the engineer.
        /// </summary>
        public IEnumerable<string> ProgrammingLanguages { get; set; } = new List<string>();
    }
}