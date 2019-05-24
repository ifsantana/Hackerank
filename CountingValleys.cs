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

class CountingValleys {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        int totalSteps = s.Count(), path = 0, totalValleys = 0, lastStep = 0;

        for(int i = 0; i < totalSteps; i++)
        { 
            if(s[i] == 'U')
            {
                path++;
            }
            else
            {
                path--;
            }

            if((lastStep == 0) && (path == -1))
            {
                totalValleys++;
            }
            
            lastStep = path;
        }
        
        return totalValleys;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
