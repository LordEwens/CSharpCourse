using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CsharpBasic_7A
{
    class Program
    {
        static void Main(string[] args)
        {
               // Single line
               /*
                * Multi
                * Line
                */
                
            Console.WriteLine("Welcome to Lexicon!");
            Console.WriteLine("Welcome to Lexicon!");
            Console.Write("Welcome to C#\t");
            Console.Write("Welcome to C#\n");

            // Variable
            string firstName = "David";
            string lastName = "Ewens";
            Console.WriteLine("Welcome to Lexicon, " + firstName + "!");
            Console.WriteLine("Hi {0} {1}! Welcome", firstName, lastName);

            Console.ReadKey();
        }
    }
}
