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

class SortingBubbleSort {

    static void countSwaps(int[] a) {
        
        int counter = 0, n = a.Length - 1;

        if(IsSorted(a))
        {
            PrintResult(a, n, counter); 
        }
        else
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(a[j] > a[j+1])
                    {
                        Swap(a, j, j+1);
                        counter++;
                    }
                }
            }
            PrintResult(a, n, counter);
        }
    }

    static void PrintResult(int[] a, int n, int counter) 
    {
        Console.WriteLine(string.Format("Array is sorted in {0} swaps.", counter));
        Console.WriteLine(string.Format("First Element: {0}", a[0]));
        Console.WriteLine(string.Format("Last Element: {0}", a[n]));
    }

    static void Swap(int[] arr, int biggest, int lowest)
    {
       int temp = arr[biggest];
        arr[biggest] = arr[lowest];
        arr[lowest] = temp;
    }

    static bool IsSorted(int[] arr)
    {
        int n = arr.Length - 1;

        for(int i = 0; i < n; i++)
        {
            if(arr[i] > arr[i+1])
                return false;
        }
        
        return true;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        countSwaps(a);
    }
}
