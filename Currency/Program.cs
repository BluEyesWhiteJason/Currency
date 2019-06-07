using System;
using System.Globalization;

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
            // Method for us format found here: https://www.howtogeek.com/howto/programming/format-a-string-as-currency-in-c/
            // Method for other formats found here: https://stackoverflow.com/questions/35499585/string-format-for-japanese-currency
            string usa = String.Format("US: {0:c}", total);
            string sw = total.ToString("C", new CultureInfo("sv-SE"));
            string jp = total.ToString("C", new CultureInfo("ja-JP"));
            string thai = total.ToString("C", new CultureInfo("th-TH"));



            Console.WriteLine(usa);
            Console.WriteLine("Sweden: " + sw);
            Console.WriteLine("Japan: " + jp);
            Console.WriteLine("Thai: " + thai);
        }
    }
}
