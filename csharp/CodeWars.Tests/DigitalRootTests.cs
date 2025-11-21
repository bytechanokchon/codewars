using CodeWars.Solutions;

namespace CodeWars.Tests;

public class DigitalRootTests
{
    [Fact]
    public void InputIsSingleDigit_ReturnSameDigit()
    {
        // Arrange
        int number = 7;

        // Act
        int result = DigitalRoot.Solutions(number);

        // Assert
        int expected = 7;
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(16, 7)]
    [InlineData(942, 6)]
    [InlineData(132189, 6)]
    [InlineData(493193, 2)]
    public void InputHasMultipleDigits_ReturnCorrectDigitalRoot(long number, int expected)
    {
        // Act
        int result = DigitalRoot.Solutions(number);

        // Assert
        Assert.Equal(expected, result);
    }
}
