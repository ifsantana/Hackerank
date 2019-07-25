using System;
using System.Collections.Generic;
using System.IO;

class RunningTimeAndComplexity {

    

    static void Main(String[] args) {

        int T = Int32.Parse(Console.ReadLine());

        while(T-->0){
            int current = Int32.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(current));
        }
    }

    static string IsPrime(int number)
    {
        int counter = 0;

        if(number <= 1)
        {
            return "Not prime";
        }
        
        if(number == 2)
        {
            return "Prime";
        }

        for(int i = 2; i*i <= number; i++)
        {
            if(number % i == 0)
            {
                return "Not prime";
            }
        }
        
        return "Prime";
    }
}

