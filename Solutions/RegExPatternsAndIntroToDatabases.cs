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

class RegExPatternsAndIntroToDatabases {

    static void Main(string[] args) {
        Dictionary<string, string> results = new Dictionary<string, string>();
        int N = Convert.ToInt32(Console.ReadLine());

        for (int NItr = 0; NItr < N; NItr++) 
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');
            
            if(firstNameEmailID[1].EndsWith("@gmail.com"))
            {
                results.Add(firstNameEmailID[1], firstNameEmailID[0]);
            }
        }
        
        foreach(var item in results.OrderBy(key => key.Value))
        {
            Console.WriteLine(item.Value);
        }
    }
}
