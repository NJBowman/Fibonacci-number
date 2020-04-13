using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci());
        }

        static long fibonacci()
        {
            //Step 1 - Base values
            long max = 2000000;
            long x = 1;
            long y = 2;
            long z = 0;

            // Step 2 - add 2 terms to make a third
            z = x + y;

            // Step 3 -  transfer values to move onto further values
            x = y;
            y = z;

            // Step 4 - repeat
            // while(z < max) - prevent going above 4 million 
            // { }


            return z;
        }

    }
}
