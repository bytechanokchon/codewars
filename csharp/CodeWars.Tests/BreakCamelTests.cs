using CodeWars.Solutions;

namespace CodeWars.Tests;

public class BreakCamelTests
{
    [Fact]
    public void InputCamelCase_ReturnBreakCamelCase()
    {
        // Arrange
        string text = "camelCassing";

        // Act
        string result = BreakCamel.Solution(text);

        // Assert
        string expected = "camel Cassing";
        Assert.Equal(expected, result);
    }
}
