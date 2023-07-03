using System;

public static class PlayAnalyzer
{

    
    public static string AnalyzeOnField(int shirtNum)
    {
         string position = "";

        switch (shirtNum)
        {
            case 1:position = "goalie";
                break;
            case 2:position = "left back";
                break;
            case 3:case 4:
                   position = "center back";
                break;

            case 5:
                position = "right back";
                break;

            case 6:case 7:case 8:
                position = "midfielder";
                break;

            case 9:
                position = "left wing";
                break;

            case 10:
                position = "striker";
                break;

            case 11:
                position = "right wing";
                break;
            default:
              throw new ArgumentOutOfRangeException();
               
        }

       return position;
    }

public static string AnalyzeOffField(object report)
{
     string res;
        switch (report)
        {
            case int num:
                res = "There are " + report.ToString() + " supporters at the match.";
                break;
            case string msg:
                res = msg;
                break;
            case Foul f:
                res = f.GetDescription();
                break;
            case Injury i:
                res = "Oh no! " + i.GetDescription() + " Medics are on the field.";
                break;
            case Incident i:
                res = i.GetDescription();
                break;
            case Manager m when m.Club == null:
                res = m.Name;
                break;
            case Manager m:
                res = m.Name + " (" + m.Club + ")";
                break;
            default:
                throw new ArgumentException();
        }
        return res;
}

}
