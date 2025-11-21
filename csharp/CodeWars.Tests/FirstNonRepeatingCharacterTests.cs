using CodeWars.Solutions;

namespace CodeWars.Tests;

public class FirstNonRepeatingCharacterTests
{
    [Theory]
    [InlineData("a", "a")]
    [InlineData("stress", "t")]
    [InlineData("moonmen", "e")]
    [InlineData("sTreSS", "T")]
    public void InputHasUniqueCharacter_ReturnFirstUniqueCharacter(string text, string expected)
    {
        // Act
        string result = FirstNonRepeatingCharacter.Solution(text);

        // Assert
        Assert.Equal(expected, result);
    }
}
