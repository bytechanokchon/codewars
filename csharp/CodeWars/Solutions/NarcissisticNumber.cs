namespace CodeWars.Solutions;

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
