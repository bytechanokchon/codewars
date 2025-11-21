using System;
using CodeWars.Solutions;

namespace CodeWars.Tests;

public class FindParityOutlierTests
{
    [Fact]
    public void InputHasOneOddAmongEvens_ReturnOddNumber()
    {
        // Arrange
        int[] integers = new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 };

        // Act
        int result = FindParityOutlier.Solution(integers);

        // Assert
        int expected = 11;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InputHasOneEvenAmongOdds_ReturnEvenNumber()
    {
        // Arrange
        int[] integers = new int[] { 160, 3, 1719, 19, 11, 13, -21 };

        // Act
        int result = FindParityOutlier.Solution(integers);

        // Assert
        int expected = 160;
        Assert.Equal(expected, result);
    }
}
