using System;
using CodeWars.Solutions;

namespace CodeWars.Tests;

public class CreditCardMaskTests
{
    [Theory]
    [InlineData("4556364607935616", "############5616")]
    [InlineData("64607935616", "#######5616")]
    public void InputLongerThan4Characters_ReturnMaskAllButLast4(string text, string expected)
    {
        // Act
        string result = CreditCardMask.Solutions(text);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InputShorterThan4_ReturnNoMasks()
    {
        // Arrange
        string text = "1";

        // Act
        string result = CreditCardMask.Solutions(text);

        // Assert
        string expected = "1";
        Assert.Equal(expected, text);
    }

    [Fact]
    public void InputEmpty_ReturnEmpty()
    {
        // Arrange
        string text = string.Empty;

        // Act
        string result = CreditCardMask.Solutions(text);

        // Assert
        string expected = string.Empty;
        Assert.Equal(expected, text);
    }
}
