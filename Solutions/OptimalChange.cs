using System;

namespace Challenge
{
    class Change
    {
        public long coin2 = 0;
        public long bill5 = 0;
        public long bill10 = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            long s = 27; // Change this value to perform other tests
            Change m = Program.OptimalChange(s);

            Console.WriteLine("Coin(s)  2€: " + m.coin2);
            Console.WriteLine("Bill(s)  5€: " + m.bill5);
            Console.WriteLine("Bill(s) 10€: " + m.bill10);

            long result = m.coin2 * 2 + m.bill5 * 5 + m.bill10 * 10;
            Console.WriteLine("\nChange given = " + result);

        }

        public static Change OptimalChange(long s)
        {
            int coin2 = 2, bill5 = 5, bill10 = 10;
            int total = 0;
            Change change = new Change();

            if (s == 0 || s == 1)
                throw new Exception("Impossible");

            while (total < s)
            {
                if (total + bill10 <= s)
                {
                    total += bill10;
                    change.bill10++;
                }
                else if (total + bill5 <= s)
                {
                    total += bill5;
                    change.bill5++;
                }
                else if (total + coin2 <= s)
                {
                    total += coin2;
                    change.coin2++;
                }
            }

            return change;
        }
    }
}
