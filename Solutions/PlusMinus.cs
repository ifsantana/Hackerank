using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class PlusMinus {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr, int size) {
    
        int positives = calculatesPositives(arr, size);
        int negatives = calculatesNegatives(arr, size);
        int zeros = calculatesZeros(arr, size);

        decimal positivesResult = Decimal.Divide(positives, size);
        decimal negativesResult = Decimal.Divide(negatives, size);
        decimal zerosResult = Decimal.Divide(zeros, size);

        Console.WriteLine(positivesResult.ToString("0.000000"));
        Console.WriteLine(negativesResult.ToString("0.000000"));
        Console.WriteLine(zerosResult.ToString("0.000000"));
    }

    static int calculatesPositives(int[] arr, int size)
    {
        int positives = 0;

        for(int i = 0; i < size; i++)
        {
            if(arr[i] > 0)
            {
                positives++;
            }
        }
        
        return positives;
    }

    static int calculatesNegatives(int[] arr, int size)
    {
        int negatives = 0;

        for(int i = 0; i < size; i++)
        {
            if(arr[i] < 0)
            {
                negatives++;
            }
        }
        
        return negatives;   
    }

    static int calculatesZeros(int[] arr, int size)
    {
        int zeros = 0;

        for(int i = 0; i < size; i++)
        {
            if(arr[i] == 0)
            {
                zeros++;
            }
        }
        
        return zeros;
    }


    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr, n);
    }
}
