namespace CodeWars.Solutions;

public class CountCharacterInString
{
    public static Dictionary<char, int> Solution(string str)
    {
        Dictionary<char, int> resultDict = new Dictionary<char, int>();

        char[] characters = str.ToCharArray();

        foreach (char character in characters)
        {
            if (resultDict.TryGetValue(character, out int amount))
            {
                resultDict[character] = (amount + 1);
            }
            else
            {
                resultDict.Add(character, 1);
            }
        }

        return resultDict;
    }
}
