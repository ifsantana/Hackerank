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

class Solution {

    static void ReadArray(int[] arr, int d)
    {
        int[] aux = new int[arr.Length], temp = new int[arr.Length];
            Array.Copy(arr, aux, d);
            Array.ConstrainedCopy(arr, d, temp, 0, arr.Length - d);

            int counter = arr.Length - d;
            for (int i = 0; i < d; i++)
            {
                temp[counter] = aux[i];
                counter++;
            }
            Print(temp);
    }

    static void Print(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }


    static void Main(string[] args) {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        ReadArray(a, d);

    }
}
