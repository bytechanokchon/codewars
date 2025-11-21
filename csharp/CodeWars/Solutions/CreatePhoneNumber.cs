using System.Text;

namespace CodeWars.Solutions;

// From: https://www.codewars.com/kata/525f50e3b73515a6db000b83
public class CreatePhoneNumber
{
    public static string Solution(int[] numbers)
    {
        StringBuilder numberStrBuilder = new StringBuilder();

        for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
        {
            // pre-condition
            switch (currentIndex)
            {
                case 0:
                    numberStrBuilder.Append("(");
                    break;
            }

            // process
            numberStrBuilder.Append(numbers[currentIndex]);

            // post-condition
            switch (currentIndex)
            {
                case 2:
                    numberStrBuilder.Append(") ");
                    break;
                case 5:
                    numberStrBuilder.Append("-");
                    break;
            }
        }

        return numberStrBuilder.ToString();
    }
}
