using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter amount one :");
            string input1 = Console.ReadLine();
            double.TryParse(input1, out double amount1);
            while (!double.TryParse(input1, out amount1))
            {
                Console.WriteLine("Sorry, that was not a valid response, please re-enter amount ");
                input1 = Console.ReadLine();
                double.TryParse(input1, out amount1);
            }
            //Console.WriteLine($"{input1}");

            Console.WriteLine("Please enter amount two :");
            string input2 = Console.ReadLine();
            double.TryParse(input2, out double amount2);
            while (!double.TryParse(input2, out amount2))
            {
                Console.WriteLine("Sorry, that was not a valid response, please re-enter amount");
                input2 = Console.ReadLine();
                double.TryParse(input2, out amount2);
            }
            //Console.WriteLine($"{input2}");

            Console.WriteLine("Please enter amount three :");
            string input3 = Console.ReadLine();
            double.TryParse(input3, out double amount3);
            while (!double.TryParse(input3, out amount3))
            {
                Console.WriteLine("Sorry, that was not a valid response, please re-enter amount ");
                input3 = Console.ReadLine();
                double.TryParse(input3, out amount3);
            }
            //Console.WriteLine($"{input3}");
            double total_amount = (amount1 + amount2 + amount3);
            Console.WriteLine($"{total_amount}");

            double avg_amount = (total_amount) / 3;
            Console.WriteLine($"{avg_amount}");

            double[] amounts_array = {amount1, amount2, amount3};
            Console.WriteLine($"{amounts_array.Min()}");
            Console.WriteLine($"{amounts_array.Max()}");

            Console.WriteLine($"US: {total_amount.ToString("C",CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.WriteLine($"Swedish: { total_amount.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE"))}");
            Console.WriteLine($"Japanese: {total_amount.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"))}");
            Console.WriteLine($"Thai: {total_amount.ToString("C", CultureInfo.CreateSpecificCulture("th-TH"))}");
        }
    }
}
