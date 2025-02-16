using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();
            int number = 0;

            bool success = int.TryParse(numInput, out number);

            if (success)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Failed to convert!");
            }

                Console.ReadLine();
        }
    }
}
