using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {

        var pattern = new Regex(@"^[ACGT]+$");
        Dictionary<char, int> DnaPair = new Dictionary<char, int>()
        {
            { 'A' , 0},
            { 'C',  0},
            { 'G' , 0},
            { 'T' , 0},
         };


        if (sequence == "")
        {
            DnaPair = new Dictionary<char, int>()
            {
                { 'A' , 0},
                { 'C',  0},
                { 'G' , 0},
                { 'T' , 0},
            };
        }
        else if (!pattern.IsMatch(sequence))
        {
            throw new ArgumentException();
        }
        else
        {
            foreach (char ch in sequence)
            {
                DnaPair[ch]++;
            }

        }

        return DnaPair;
    }

}
