using OCP.Abstractions;

namespace OCP
{
    /// <summary>
    /// Represents a Secretary employee
    /// </summary>
    public class Secretary : Employee
    {
        /// <summary>
        /// Initializes a new instance of the Secretary class.
        /// </summary>
        /// <param name="fullName">The full name of the Secretary</param>
        /// <param name="baseSalary">The base salary of the Secretary</param>
        /// <param name="bonusCalculator">The bonus calculator for the Secretary</param>
        /// <param name="typingSpeed">The typing speed of the Secretary</param>
        public Secretary(string fullName, double baseSalary, IBonusCalculator bonusCalculator, int typingSpeed) : base(fullName, baseSalary, bonusCalculator)
        {
            TypingSpeed = typingSpeed;
        }

        /// <summary>
        /// Gets or sets the typing speed of the Secretary
        /// </summary>
        public int TypingSpeed { get; set; }
    }
}