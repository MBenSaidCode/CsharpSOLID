using OCP.Abstractions;
using System.Collections.Generic;

namespace OCP
{
    /// <summary>
    /// Represents the Head of Product in the organization
    /// </summary>
    public class HeadOfProduct : Employee
    {
        /// <summary>
        /// Initializes a new instance of the HeadOfProduct class
        /// </summary>
        /// <param name="fullName">The full name of the Head of Product</param>
        /// <param name="baseSalary">The base salary of the Head of Product</param>
        /// <param name="bonusCalculator">The bonus calculator for the Head of Product</param>
        public HeadOfProduct(string fullName, double baseSalary, IBonusCalculator bonusCalculator) : base(fullName, baseSalary, bonusCalculator)
        {
        }

        /// <summary>
        /// Gets or sets the product lines managed by the Head of Product
        /// </summary>
        public IEnumerable<string> ProductLines { get; set; } = new List<string>();
    }
}