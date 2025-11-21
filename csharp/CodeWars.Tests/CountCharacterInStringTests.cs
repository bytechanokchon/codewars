using CodeWars.Solutions;

namespace CodeWars.Tests;

// From: https://www.codewars.com/kata/52efefcbcdf57161d4000091
public class CountCharacterInStringTests
{
    [Fact]
    public void InputIsNotDuplicate_ReturnCorrectCount()
    {
        // Arrange
        string str = "abcd";

        // Act
        Dictionary<char, int> resultDict = CountCharacterInString.Solution(str);

        // Assert
        Dictionary<char, int> expectedDict = new Dictionary<char, int>()
        {
            { 'a', 1 },
            { 'b', 1 },
            { 'c', 1 },
            { 'd', 1 },
        };

        int expectedEqualCount = expectedDict.Count;
        int resultEqualCount = 0;

        if (resultDict.Count == expectedDict.Count)
        {
            foreach (KeyValuePair<char, int> expectedKeyVal in expectedDict)
            {
                if (resultDict.TryGetValue(expectedKeyVal.Key, out int value))
                {
                    if (expectedKeyVal.Value == value) resultEqualCount++;
                }
                else
                {
                    break;
                }
            }
        }

        Assert.Equal(expectedEqualCount, resultEqualCount);
    }

    [Fact]
    public void InputHasDuplicate_ReturnCorrectCount()
    {
        // Arrange
        string str = "aabcdd";

        // Act
        Dictionary<char, int> resultDict = CountCharacterInString.Solution(str);

        // Assert
        Dictionary<char, int> expectedDict = new Dictionary<char, int>()
        {
            { 'a', 2 },
            { 'b', 1 },
            { 'c', 1 },
            { 'd', 2 },
        };

        int expectedEqualCount = expectedDict.Count;
        int resultEqualCount = 0;

        if (resultDict.Count == expectedDict.Count)
        {
            foreach (KeyValuePair<char, int> expectedKeyVal in expectedDict)
            {
                if (resultDict.TryGetValue(expectedKeyVal.Key, out int value))
                {
                    if (expectedKeyVal.Value == value) resultEqualCount++;
                }
                else
                {
                    break;
                }
            }
        }

        Assert.Equal(expectedEqualCount, resultEqualCount);
    }
}
