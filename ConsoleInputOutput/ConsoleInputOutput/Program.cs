using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is Shani!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");

            Console.WriteLine();

            Console.WriteLine("Nice to meet you. I'm 23!");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oh great! You're " + age + ".");

            Console.ReadLine();
        }
    }
}
