using System;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (identifier.Contains(" "))
         return identifier.Trim();
        if (identifier.Contains("\") )
          return identifier.Replace("CTRL");
         if (identifier.Contains("-")  )  
           return identifier.ToUpper();
             
            
    }
}
