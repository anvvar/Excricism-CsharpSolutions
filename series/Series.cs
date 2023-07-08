using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        var series = new List<string>();

        if (sliceLength <= 0 ||sliceLength>numbers.Length)
        {
            throw new ArgumentException();
        }
        else
        {
            for (int i = 0; i <= numbers.Length - sliceLength; i++)
            {
                series.Add(numbers.Substring(i, sliceLength));
            }

        }

        return series.ToArray();
    }

}