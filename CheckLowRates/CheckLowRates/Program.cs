using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRates
{
    class Program
    {
        static void Main(string[] args)
        {
            double error = 5.65;
            String input;
            int payrate;
            Console.Write("Please enter hourly pay rate: ");
            input = Console.ReadLine();
            payrate = Convert.ToInt32(input);

            if (payrate < error)
                Console.WriteLine("error, payrate cannot be less that $5.65.");
        }
    }
}
