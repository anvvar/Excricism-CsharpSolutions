using System;
using System.Collections.Generic;
using System.Text;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
    
       Dictionary<string, string> codonToProtein = new Dictionary<string, string>
        {
            { "AUG", "Methionine" },
            { "UUU", "Phenylalanine" },
            { "UUC", "Phenylalanine" },
            { "UUA", "Leucine" },
            { "UUG", "Leucine" },
            { "UCU", "Serine" },
            { "UCC", "Serine" },
            { "UCA", "Serine" },
            { "UCG", "Serine" },
            { "UAU", "Tyrosine" },
            { "UAC", "Tyrosine" },
            { "UGU", "Cysteine" },
            { "UGC", "Cysteine" },
            { "UGG", "Tryptophan" },
            { "UAA", "STOP" },
            { "UAG", "STOP" },
            { "UGA", "STOP" }
        };

        List<string> proteinSequence = new List<string>();
        for (int i = 0; i < strand.Length; i += 3)
        {
            string codon = strand.Substring(i, Math.Min(3, strand.Length - i));
            string protein = codonToProtein.GetValueOrDefault(codon);
            
            if (protein == null)
                throw new ArgumentException($"Invalid codon: {codon}");

            if (protein == "STOP")
                break;

            proteinSequence.Add(protein);
        }

        return proteinSequence.ToArray();

    }
}