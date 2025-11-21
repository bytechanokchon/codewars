
namespace CodeWars.Solutions;

// From: https://www.codewars.com/kata/54ff3102c1bad923760001f3
public class VowelCount
{
    public static int Solution(string str)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        int vowelCount = 0;

        foreach (char character in str)
        {
            foreach (char vowel in vowels)
            {
                if (Char.ToLower(character).Equals(vowel))
                {
                    vowelCount++;
                    break;
                }
            }
        }

        return vowelCount;
    }
}
