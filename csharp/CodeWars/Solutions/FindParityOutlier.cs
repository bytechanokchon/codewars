using System;

namespace CodeWars.Solutions;

// From: https://www.codewars.com/kata/5526fc09a1bbd946250002dc
public class FindParityOutlier
{
    public static int Solution(int[] integers)
    {
        int lastEven = 0;
        int lastOdd = 0;
        int evenCount = 0;
        int oddCount = 0;

        for (int index = 0; index < integers.Length; index++)
        {
            int number = integers[index];

            bool isEven = number % 2 == 0;

            if (isEven)
            {
                lastEven = number;
                evenCount++;
            }
            else
            {
                lastOdd = number;
                oddCount++;
            }
        }

        bool isAmongEven = evenCount >= oddCount;

        return (isAmongEven) ? lastOdd : lastEven;
    }
}
