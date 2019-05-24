using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class TimeConversion {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
         DateTime time = DateTime.Parse(s);

         return time.ToString("HH:mm:ss");
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
