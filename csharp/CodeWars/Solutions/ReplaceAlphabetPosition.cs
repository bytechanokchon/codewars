namespace CodeWars.Solutions;

// From: https://www.codewars.com/kata/546f922b54af40e1e90001da
public class ReplaceAlphabetPosition
{
    public static string Solution(string text)
    {
        char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        List<int> resultChars = new List<int>();

        foreach (char character in text)
        {
            char lowerCharacter = Char.ToLower(character);

            if (lowerCharacter < 'a' || lowerCharacter > 'z') continue;

            int alphabetIndex = 0;
            foreach (char letter in letters)
            {
                alphabetIndex++;

                if (lowerCharacter.Equals(letter)) break;
            }

            resultChars.Add(alphabetIndex);
        }

        return string.Join(' ', resultChars);
    }
}
