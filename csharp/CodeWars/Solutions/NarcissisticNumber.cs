namespace CodeWars.Solutions;

// From: https://www.codewars.com/kata/5287e858c6b5a9678200083c
public class NarcissisticNumber
{
    public static bool Solution(int value)
    {
        char[] characterNumbers = (Convert.ToString(value)).ToCharArray();
        int powValue = characterNumbers.Length;

        int result = 0;
        foreach (char characterNumber in characterNumbers)
        {
            result += (int)Math.Pow(characterNumber - '0', powValue);
        }

        return result == value;
    }
}
