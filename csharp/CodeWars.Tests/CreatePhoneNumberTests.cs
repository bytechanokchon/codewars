using System;
using CodeWars.Solutions;

namespace CodeWars.Tests;

public class CreatePhoneNumberTests
{
    [Fact]
    public void InputManyNumber_ReturnPhoneNumberFormatted()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        // Act
        string result = CreatePhoneNumber.Solution(numbers);

        // Assert
        string expected = "(123) 456-7890";
        Assert.Equal(expected, result);
    }
}
