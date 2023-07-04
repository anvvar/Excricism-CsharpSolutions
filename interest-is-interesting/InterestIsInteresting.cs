using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        //throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
        float intrest=0;
        if(balance<0)
            intrest=3.213f;
        else if(balance<1000)
            intrest=0.5f;
        else if (balance<5000)
            intrest=1.621f;
        else 
            intrest=2.475f;
        return intrest;
    }

    public static decimal Interest(decimal balance)
    {
       // throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
        decimal spBalance=0;
        decimal inr=(decimal)InterestRate(balance);
        spBalance=(inr*balance)/100;
       // Console.Writeline(spBalance);
        return spBalance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        //throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
      decimal aBalance=0;
        aBalance=Interest(balance)+balance;
        return aBalance;
        
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
       // throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    int years = 0;
    while (balance < targetBalance)
    {
        balance = AnnualBalanceUpdate(balance);
        years++;
    }
    return years;
    
    
    }
}
