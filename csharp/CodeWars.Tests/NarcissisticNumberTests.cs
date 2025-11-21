using CodeWars.Solutions;

namespace CodeWars.Tests;

public class NarcissisticNumberTests
{
    [Theory]
    [InlineData(153)]
    [InlineData(370)]
    [InlineData(371)]
    [InlineData(9474)]
    public void InputIsNarcissistic_ReturnTrue(int value)
    {
        // Act
        bool result = NarcissisticNumber.Solution(value);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(10)]
    [InlineData(100)]
    [InlineData(123)]
    public void InputIsNotNarcissistic_ReturnFalse(int value)
    {
        // Act
        bool result = NarcissisticNumber.Solution(value);

        // Assert
        Assert.False(result);
    }
}
