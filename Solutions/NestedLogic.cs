using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

class NestedLogic {

    static void Main(String[] args) {
        CultureInfo culture = new CultureInfo("pt-BR");
        DateTime returnDate = DateTime.Parse(Console.ReadLine(), culture);
        DateTime expectedDate = DateTime.Parse(Console.ReadLine(), culture);

        CalculateCharge(expectedDate, returnDate);
    }

    static void CalculateCharge(DateTime expectedDate, DateTime returnDate)
    {
        if (returnDate.Date <= expectedDate.Date)
        {
            Console.WriteLine(0);
        }
        else if(returnDate.Year > expectedDate.Year)
        {
            Console.WriteLine(10000);
        }
        else if(returnDate.Month > expectedDate.Month && returnDate.Year == expectedDate.Year)
        {
            Console.WriteLine(500 * (returnDate.Month - expectedDate.Month));
        }
        else if(returnDate.Day > expectedDate.Day && returnDate.Year == expectedDate.Year)
        {
            Console.WriteLine(15 * (returnDate.Day - expectedDate.Day));
        }
    }
}

