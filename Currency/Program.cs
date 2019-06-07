﻿using System;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for amounts
            Console.WriteLine("Please enter first dollar amount: ");
            double firstAmt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter second dollar amount: ");
            double secondAmt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter third dollar amount: ");
            double thirdAmt = Convert.ToDouble(Console.ReadLine());

            //Calc average
            double total = firstAmt + secondAmt + thirdAmt;
            double avg = total / 3;

            Console.WriteLine("The average of the entered values is $" + Math.Round(avg, 2));

            // Place values in array, sort, say highest and lowest
            double[] values = { firstAmt, secondAmt, thirdAmt };
            Array.Sort(values);

            Console.WriteLine("The highest value entered is $" + Math.Round(values[2], 2));

            Console.WriteLine("The lowest value entered is $" + Math.Round(values[0], 2));

            // Format total as different currencies
            // Method for format found here: https://www.howtogeek.com/howto/programming/format-a-string-as-currency-in-c/
            string usa = String.Format("US: {0:C}", total);
            string sw = String.Format("Sweden: {0:C} kr", total);
            string jp = String.Format("Japan: ￥{0:C}", total);
            string thai = String.Format("Thailand: ฿{0:C}", total);



            Console.WriteLine(usa);
            Console.WriteLine(sw);
            Console.WriteLine(jp);
            Console.WriteLine(thai);
        }
    }
}