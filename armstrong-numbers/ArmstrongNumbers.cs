using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int sum = 0;
        int count = number.ToString().Length;
        int check = number;

        while (number > 0)
        {
            sum += (int)Math.Pow(number%10, count);
            number /= 10;
        }

       return sum==check;
    }
}