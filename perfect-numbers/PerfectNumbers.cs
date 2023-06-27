using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{

    public static Classification Classify(int number)
    {
        int factors = 0;
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    factors += i;
                }
            }
        }

        if (number == factors)
        {
            return Classification.Perfect;
        }
        else if (number < factors)
        {
            return Classification.Abundant;
        }
        else
        {
            return Classification.Deficient;
        }
    }
}
