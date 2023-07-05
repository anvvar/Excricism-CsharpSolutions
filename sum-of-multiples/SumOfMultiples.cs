using System;
using System.Collections.Generic;
using System.Linq;
public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
       HashSet<int> store = new HashSet<int>();
        int factors = 0;
       
        foreach (int number in multiples) 
        {
            for(int i = 1; i <max; i++)
            {
                factors = number * i;
                if(factors<max) 
                {
                    store.Add(factors);
                }
            }
        
        }
         
       return store.Sum();
    }
}