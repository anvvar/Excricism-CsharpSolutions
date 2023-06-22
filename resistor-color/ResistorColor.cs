using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        //color.ToUpper();
        int code = color switch
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
            _ => throw new ArgumentOutOfRangeException(),

        };
        return code;
    }

    public static string[] Colors()
    {
        string[] colors = {  
            "black" ,
            "brown" ,
            "red" ,
            "orange" ,
            "yellow" ,
            "green" ,
            "blue" ,
            "violet" ,
            "grey" ,
            "white" };
        return colors;
    }
    
}