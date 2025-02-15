using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;

            //Increment by one.
            age++;
            age = age + 1;
            age += 1;
            Console.WriteLine(age);

            //Decrement by one.
            age--;
            age = age - 1;
            age -= 1;
            Console.WriteLine(age);

            //Multiplication
            age *= 10;
            Console.WriteLine(age);

            //Division (It's better to use a double for division so that we can get the remainder).
            double money = 23;
            money /= 10;
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
