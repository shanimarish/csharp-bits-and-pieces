using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int answer = num1 * num2;
            int actualAnswer = 0;

            Console.WriteLine("What's the value of " + num1 + " x " + num2 + "?");

            while (answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong!");
                }
            }
            Console.WriteLine("Well done!");

            Console.ReadLine();
        }
    }
}
