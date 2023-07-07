using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int Left = 0;
        int Right = input.Length - 1;
        int m;

        while (Left <= Right)
        {
            m = ((Left + Right) / 2);
            if (input[m] < value)
            {
                Left = m + 1;
            }
            else if (input[m] > value)
            {
                Right = m - 1;
            }
            else
            {
                return m;
            }
        }
        return -1;

    }
}