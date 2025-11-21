using CodeWars.Solutions;

namespace CodeWars.Tests;

public class DuplicateCountTests
{
    [Theory]
    [InlineData("abcde", 0)]
    public void InputHasNoDuplicate_ReturnZero(string text, int expected)
    {
        // Act
        int result = DuplicateCount.Solution(text);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("abcdee", 1)]
    [InlineData("aabbcde", 2)]
    [InlineData("aabBcde", 2)]
    [InlineData("indivisibility", 1)]
    [InlineData("Indivisibilities", 2)]
    [InlineData("aA11", 2)]
    [InlineData("ABBA", 2)]
    public void InputHasDuplicates_ReturnCorrectCount(string text, int expected)
    {
        // Act
        int result = DuplicateCount.Solution(text);

        // Assert
        Assert.Equal(expected, result);
    }
}
