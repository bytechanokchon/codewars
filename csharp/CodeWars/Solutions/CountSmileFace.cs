using System;

namespace CodeWars.Solutions;

// From: https://www.codewars.com/kata/583203e6eb35d7980400002a
public class CountSmileFace
{
    public static int Solution(string[] smileys)
    {
        char[] eyes = new char[] { ':', ';' };
        char[] noses = new char[] { '-', '~' };
        char[] mouths = new char[] { ')', 'D' };

        int smileCorrectCount = 0;

        foreach (string smile in smileys)
        {
            bool isInvalidEmoji = smile.Length < 2;
            if (isInvalidEmoji) continue;

            bool isHasNose = smile.Length == 3;

            char itemEye = smile[0];
            char? itemNose = (isHasNose) ? smile[1] : null;
            char itemMouth = (isHasNose) ? smile[2] : smile[1];

            bool isCorrectEye = false;
            foreach (char eye in eyes)
            {
                if (itemEye.Equals(eye))
                {
                    isCorrectEye = true;
                    break;
                }
            }

            bool isCorrectNose = false;
            if (isHasNose)
            {
                foreach (char nose in noses)
                {
                    if (itemNose.Equals(nose))
                    {
                        isCorrectNose = true;
                        break;
                    }
                }
            }

            bool isCorrectMouth = false;
            foreach (char mouth in mouths)
            {
                if (itemMouth.Equals(mouth))
                {
                    isCorrectMouth = true;
                    break;
                }
            }

            if ((isCorrectEye && isCorrectMouth))
            {
                if (isHasNose && !isCorrectNose) continue;

                smileCorrectCount++;
            }
        }

        return smileCorrectCount;
    }
}
