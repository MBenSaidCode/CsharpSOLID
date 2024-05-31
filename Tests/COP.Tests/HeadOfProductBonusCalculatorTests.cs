using OCP.BonusCalculators;

namespace COP.Tests;

public class HeadOfProductBonusCalculatorTests
{
    [Theory(DisplayName = "Successful scenario")]
    [InlineData(1000, 140)]
    [InlineData(2500, 350)]
    public void CalculateBonus_WithValidInput_ReturnsExpectedBonus(double baseSalary, double expectedValue)
    {
        // Arrange : Create an instance of the HeadOfProductBonusCalculator class
        var sut = new HeadOfProductBonusCalculator();

        // Act : Calculate the bonus using the CalculateBonus method
        var bonus = sut.CalculateBonus(baseSalary);

        // Assert : Assert that the calculated bonus is equal to the expected value
        Assert.Equal(expectedValue, bonus);
    }
}