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

class StairCase {

    // Complete the staircase function below.
    static void staircase(int n) {
        

        for(int i= 0; i < n; i++)
        {   
            string result = "";

            for(int j = 0; j < i+1; j++)
            {
               result = result + "#";
            }

            result = addSpaces(result.Length, n) + result;
            Console.WriteLine(result);
        }

    }

    static string addSpaces(int length, int size) 
    {
        string spaces = "";

        for(int i = 0; i < size-length; i++)
        {
            spaces = spaces + " ";
        }

        return spaces;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
