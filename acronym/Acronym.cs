using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
       string acronym = "";

        string[] words = phrase.Split(new char[] { ' ', '-' });
        
        foreach (string word in words)
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
               foreach (char ch in word)
                {
                    if (char.IsLetter(ch))
                    {
                        acronym += char.ToUpper(ch);
                        break;

                    }
                }
            }
        }

        return acronym;
    }
}