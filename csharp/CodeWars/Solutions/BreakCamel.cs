using System;
using System.Text;

namespace CodeWars.Solutions;

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
