using OCP.BonusCalculators;

namespace COP.Tests;

public class SecretaryBonusCalculatorTests
{
    [Theory(DisplayName = "Successful scenario")]
    [InlineData(1000, 110)]
    [InlineData(2500, 250)]
    public void CalculateBonus_WithValidInput_ReturnsExpectedBonus(double baseSalary, double expectedValue)
    {
        // Arrange : Create an instance of the SecretaryBonusCalculator class
        var sut = new SecretaryBonusCalculator();

        // Act : Calculate the bonus using the CalculateBonus method
        var bonus = sut.CalculateBonus(baseSalary);

        // Assert : Assert that the calculated bonus is equal to the expected value
        Assert.Equal(bonus, expectedValue);
    }
}