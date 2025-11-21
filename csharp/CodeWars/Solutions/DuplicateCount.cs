namespace CodeWars.Solutions;

public class DuplicateCount
{
    public static int Solution(string str)
    {
        Dictionary<char, int> seenCharacters = new Dictionary<char, int>();

        foreach (char character in str)
        {
            char lowerCharacter = Char.ToLower(character);
            if (seenCharacters.TryGetValue(lowerCharacter, out int amount))
            {
                seenCharacters[lowerCharacter] = amount + 1;
            }
            else
            {
                seenCharacters.Add(lowerCharacter, 1);
            }
        }

        int duplicateCount = 0;
        foreach (KeyValuePair<char, int> seenCharacter in seenCharacters)
        {
            if (seenCharacter.Value > 1)
            {
                duplicateCount++;
            }
        }

        return duplicateCount;
    }
}
