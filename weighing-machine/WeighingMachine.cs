using System;

class WeighingMachine
{
    public double weight;
    public double tareadjustment;
    public double displayweight;
    string formattedWeight;
    public WeighingMachine(int precision)
    {
        Precision= precision;
        TareAdjustment = 5;
    }
    public int Precision { get; }
    public double Weight
    {    
        get { return weight; }
        set 
        {
            if (value<0)
            {
                throw new  ArgumentOutOfRangeException();
            }
            weight=value;

        }
    }
    public double TareAdjustment {
         get { return tareadjustment; }
         set { tareadjustment = value; }

     }
    public string DisplayWeight
    {   get
        {
            displayweight = Weight - TareAdjustment;
            string formattedWeight =displayweight.ToString($"F{Precision}"));
            return formattedWeight + " kg";
        } 
        }

}
