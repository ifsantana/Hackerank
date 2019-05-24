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

class RepeatedString {

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
    
        var count = countOcurrences(s);

       var possibleStringRepeatitions = n / s.Length;
        count *= possibleStringRepeatitions;
        var offsetStringLength = n % s.Length;

        for (int i = 0; i < offsetStringLength; i++)
        {
            if (s[i] == 'a')
                count++;
        }

        return count;
    }

    static long countOcurrences(string content)
    {
        long counter = 0;
        
        for(int i = 0; i < content.Count(); i++)
        {
            if(string.Equals(content[i].ToString(), "a"))
            {
                counter++;
            }
        }

        return counter;
    } 

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);
        
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
