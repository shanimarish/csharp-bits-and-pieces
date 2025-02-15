using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarAndConstKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var Keyword
            //The compiler will automatically find out what type it is based on the value you initialize the variable with.
            //Too much use of var especially if the type is not obvious will affect the readability of your code.
            var age = 23;
            Console.WriteLine(age);

            var bigNumber = 90000L;
            Console.WriteLine(bigNumber);

            var negative = "-55.2D";
            Console.WriteLine(negative);

            var precision = 5.000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money);

            var name = "Aba";
            Console.WriteLine(name);

            var letter = 'a';
            Console.WriteLine(letter);

            //Const Keyword
            //Const cannot be changed.

            const int vat = 20;
            Console.WriteLine(vat);

            Console.ReadLine();
        }
    }
}
