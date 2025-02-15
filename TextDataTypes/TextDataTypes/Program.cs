using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Abba"; //Double quotation for string (Speech Marks).
            char letter = 'a'; //Single quotation for char (Apostrophes).

            //String can be empty while char can't but we can use '\0'.

            Console.Write("Your name is: "); //Console.Write will not add another line to the output.
            Console.Write(name);

            Console.WriteLine();
            Console.Write(letter);

            Console.ReadLine();
        }
    }
}
