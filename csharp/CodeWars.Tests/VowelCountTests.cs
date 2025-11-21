using CodeWars.Solutions;

namespace CodeWars.Tests;

public class VowelCountTests
{
    [Fact]
    public void InputIsNoVowel_ReturnZero()
    {
        // Arrange
        string text = "";

        // Act
        int result = VowelCount.Solution(text);

        // Assert
        int expected = 0;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InputHasMultipleVowel_ReturnCorrectCount()
    {
        // Arrange
        string text = "abracadabra";

        // Act
        int result = VowelCount.Solution(text);

        // Assert
        int expected = 5;
        Assert.Equal(expected, result);
    }
}
