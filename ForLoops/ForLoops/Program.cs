using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message you want to repeat: ");
            string message = Console.ReadLine();
            Console.Write("How many times do you want to repeat your message?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Please enter a value above zero.");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
            }

            Console.ReadLine();  
        }
    }
}
