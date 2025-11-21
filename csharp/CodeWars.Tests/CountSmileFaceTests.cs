using CodeWars.Solutions;

namespace CodeWars.Tests;

public class CountSmileFaceTests
{
    [Theory]
    [InlineData(":),;(,;},:-D", 2)]
    [InlineData(";D,:-(,:-),;~)", 3)]
    public void InputEmoji_ReturnSmileFaceCount(string smileysText, int expected)
    {
        // Arrange
        string[] smileys = smileysText.Split(",");

        // Act
        int result = CountSmileFace.Solution(smileys);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(":,;,;*,:0", 0)]
    public void InputInvalidEmoji_ReturnSmileFaceCount(string smileysText, int expected)
    {
        // Arrange
        string[] smileys = smileysText.Split(",");

        // Act
        int result = CountSmileFace.Solution(smileys);

        // Assert
        Assert.Equal(expected, result);
    }
}
