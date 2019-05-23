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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        int numberOfPairs = 0;
        
        int[] colors = findColors(n, ar);

        numberOfPairs = calculatePairs(colors, ar);

        return numberOfPairs;
    }

    static int calculatePairs(int[] colors, int[] ar)
    {
        int numberOfPairs = 0;

        // calculate number of ocurrences
        foreach(var color in colors)
        {
            int colorOcurrences = 0;

            foreach(var item in ar)
            {
                if(color == item)
                    colorOcurrences++;
            }

            numberOfPairs += colorOcurrences / 2;
        }

        return numberOfPairs;
    }

    static int[] findColors(int n, int[] ar)
    {
        int counter = 0;
        int[] colors = new int[n];

        // find colors
        for(int i = 0;  i < ar.Count(); i++)
        {
            if(!Array.Exists(colors, c => c == ar[i]))
            {
                colors[counter] = ar[i];
                counter++;
            }
        }

        return colors;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
