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

class MiniMaxSum {

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        int[] test = new int[5] {5,5,5,5,5};
        long sumMax = 0, sumMin = 0;

        sumMax = Sum(arr, arr.Max());
        sumMin = Sum(arr, arr.Min());

        Console.WriteLine(sumMax.ToString() + " " + sumMin.ToString());
    }

    static long Sum(int[] arr, int parameter)
    {
        int[] finalArr = RemoveElements(arr, Array.LastIndexOf(arr, parameter));

        long sum = 0;

        for(int i = 0; i < finalArr.Count(); i++)
        {
            sum += Convert.ToInt64(finalArr[i]);
        }

        return sum;
    }

    static int[] RemoveElements(int[] arr, int indexToRemove) 
    {
        int[] result = new int[5];

        for(int i = 0; i < arr.Count(); i++)
        {
            if(i != indexToRemove)
            {
                result[i] = arr[i];
            }
        }

        return result;
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
