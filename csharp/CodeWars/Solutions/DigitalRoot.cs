using System.Text;

namespace CodeWars.Solutions;

// From: https://www.codewars.com/kata/541c8630095125aba6000c00
public class DigitalRoot
{
    public static int Solutions(long n)
    {
        if (n <= 9) return Convert.ToInt32(n);
        int result = 0;

        StringBuilder numberStrBuilder = new StringBuilder(Convert.ToString(n));

        while (numberStrBuilder.Length >= 2)
        {
            int lastNumber = 0;
            for (int index = 0; index < numberStrBuilder.Length; index++)
            {
                lastNumber += (numberStrBuilder[index] - '0');
            }

            if (lastNumber <= 9)
            {
                result = lastNumber;
                break;
            }
            else
            {
                numberStrBuilder.Clear();

                foreach (char numberCharacter in Convert.ToString(lastNumber))
                {
                    numberStrBuilder.Append(numberCharacter);
                }
            }
        }

        return result;
    }
}
