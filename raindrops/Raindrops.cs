using System;
using System.Text;

public static class Raindrops
{
    public static string Convert(int number)
    {
        StringBuilder sound = new StringBuilder();

        bool test = number % 3 == 0 || number % 5 == 0 || number % 7 == 0;
        if (test == false)
        {
            sound.Append(number);
        }
        else
        {
            if (number % 3 == 0)
            {
                sound.Append("Pling");
            }
            if (number % 5 == 0)
            {
                sound.Append("Plang");
            }
            if (number % 7 == 0)
            {
                sound.Append("Plong");
            }
        }
        return sound.ToString();
    }
}