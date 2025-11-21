using System.Text;

namespace CodeWars.Solutions;

// From: https://www.codewars.com/kata/5208f99aee097e6552000148
public class BreakCamel
{
    public static string Solution(string str)
    {
        StringBuilder resultBuilder = new StringBuilder();

        foreach (char character in str)
        {
            if (character == Char.ToUpper(character))
            {
                resultBuilder.Append(' ');
            }

            resultBuilder.Append(character);
        }

        return resultBuilder.ToString();
    }
}
