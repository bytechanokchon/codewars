using System.Text;

namespace CodeWars.Solutions;

public class FirstNonRepeatingCharacter
{
    public static string Solution(string s)
    {
        StringBuilder resultBuilder = new StringBuilder();
        
        for (int currentIndex = 0; currentIndex < s.Length; currentIndex++)
        {
            bool currentHasDupplicate = false;
            char currentCharacter = s[currentIndex];
            
            // check nexts
            for (int nextIndex = (currentIndex + 1); nextIndex < s.Length; nextIndex++)
            {
                char nextCharacter = s[nextIndex];

                if (Char.ToLower(currentCharacter) == Char.ToLower(nextCharacter))
                {
                    currentHasDupplicate = true;
                    break;
                }
            }

            // check previos
            if (!currentHasDupplicate)
            {
                for (int previosIndex = (currentIndex - 1); previosIndex >= 0; previosIndex--)
                {
                    char previosCharacter = s[previosIndex];

                    if (Char.ToLower(currentCharacter) == Char.ToLower(previosCharacter))
                    {
                        currentHasDupplicate = true;
                        break;
                    }
                }
            }

            if (!currentHasDupplicate)
            {
                resultBuilder.Append(currentCharacter);
                break;
            }
        }

        return resultBuilder.ToString();
    }
}
