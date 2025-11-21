using System;
using CodeWars.Solutions;

namespace CodeWars.Tests;

public class ReplaceAlphabetPositionTests
{
    [Fact]
    public void InputText_ReturnAlphabet()
    {
        // Arrange
        string text = "The sunset sets at twelve o' clock.";

        // Act
        string result = ReplaceAlphabetPosition.Solution(text);

        // Assert
        string expected = "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11";
        Assert.Equal(expected, result);
    }
}
