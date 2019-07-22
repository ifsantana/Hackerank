using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Sorting {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        // Track number of elements swapped during a single array traversal
        int result = 0;

        for (int i = 0; i < n; i++) {

            int numberOfSwaps = 0;
            
            for (int j = 0; j < n - 1; j++) {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1]) {
                    int current = a[j];
                    a[j] = a[j+1];
                    a[j+1] = current;
                    numberOfSwaps++;
                    result++;
                }
            }
            
            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0) {
                break;
            }
        }

        Console.WriteLine(string.Format("Array is sorted in {0} swaps.", result));
        Console.WriteLine(string.Format("First Element: {0}", a[0]));
        Console.WriteLine(string.Format("Last Element: {0}", a[n-1]));
    }
}

