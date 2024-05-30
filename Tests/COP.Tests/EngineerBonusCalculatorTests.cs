using OCP.BonusCalculators;

namespace COP.Tests;

public class EngineerBonusCalculatorTests
{
    [Theory(DisplayName = "Successful scenario")]
    [InlineData(1000, 120)]
    [InlineData(2500, 300)]
    public void CalculateBonus_WithValidInput_ReturnsExpectedBonus(double baseSalary, double expectedValue)
    {
        // Arrange : Create an instance of the EngineerBonusCalculator class
        var sut = new EngineerBonusCalculator();

        // Act : Calculate the bonus using the CalculateBonus method
        var bonus = sut.CalculateBonus(baseSalary);

        // Assert : Assert that the calculated bonus is equal to the expected value
        Assert.Equal(bonus, expectedValue);
    }
}