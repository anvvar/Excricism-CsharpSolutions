using System;
using System.Text;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        var value = new StringBuilder();
        foreach (string color in colors)
        {
            value.Append(color switch
            {
                "black" => 0,
                "brown" => 1,
                "red" => 2,
                "orange" => 3,
                "yellow" => 4,
                "green" => 5,
                "blue" => 6,
                "violet" => 7,
                "grey" => 8,
                "white" => 9,
                _ => throw new NotImplementedException()

            });
        }

        int band = int.Parse(value.ToString().Substring(0, 2));

        return band;

    }
}
