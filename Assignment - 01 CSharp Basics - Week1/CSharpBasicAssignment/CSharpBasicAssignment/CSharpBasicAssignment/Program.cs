// Creator: David Ewens, Class 7A

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharpGund
{
    class Program
    {
        private static void RunExerciseOne()
        {
            string firstName = "David", lastName = "Ewens";
            Console.WriteLine("Hello {0} {1}! I'm glad to inform you that you are the test subject of my very first assignment!", firstName, lastName);
        }

        private static void RunExerciseTwo()
        {
            string fullName;
            Console.WriteLine("What is your full name?");
            fullName = Console.ReadLine();
            Console.WriteLine("Hello {0}! Have a nice day!", fullName);
        }

        private static void RunExerciseThree()
        {
            int birthYear, birthMonth, birthDay;
            DateTime currentDate = DateTime.Now;
            
            Console.WriteLine("What year were you born? Example, 1989");
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What month were you born? Example, 10");
            birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What day were you born? Example, 29");
            birthDay = Convert.ToInt32(Console.ReadLine());

            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
            TimeSpan age = currentDate.Subtract(birthDate); // Current date minus birth date equals the current age
            Console.WriteLine("Your current age is: {0}", (Int32)(age.TotalDays/365)); // Display age in years

        }

        private static void RunExerciseFour()
        {
            // Display todays, yesterdays and tomorrows date

            // Today
            Console.WriteLine("The current date in Year-Month-Day: {0}", DateTime.Now.ToString("yyyy/MM/dd"));
            Console.WriteLine("The current date in American date format (Month-Day-Year): {0}", DateTime.Now.ToString("MM/dd/yyyy"));

            DateTime todayDate = DateTime.Now;
            // Yesterday
            DateTime yesterdayDate = todayDate.AddDays(-1);
            Console.WriteLine("Yesterday the date was: {0} (in Year-Month-Day)", yesterdayDate.ToString("yyyy/MM/dd"));

            // Tomorrow
            DateTime tomorrowDate = todayDate.AddDays(1);
            Console.WriteLine("Tomorrow the date is: {0} (in Year-Month-Day)", tomorrowDate.ToString("yyyy/MM/dd"));
        }

        private static void RunExerciseFive()
        {
            // Add two in and store as double
            int numbOne = 5, numbTwo = 4;
            double addResult = numbOne + numbTwo;

            // Add two double and store result in integer - try to fix error
            double doublePi = 3.1415, doubleE = 2.7182;
            int addDoubleResult = (int)doublePi + (int)doubleE;

            // Add two ints - one odd one even, divide odd by even and display accurate result
            int numbOdd = 3, numbEven = 4;
            Console.WriteLine("Divide odd (3) by even (4) and display result: {0}", (double)numbOdd / (double)numbEven);

        }
        private static void RunExerciseSix()
        {
            // Change string “The quick fox Jumped Over the DOG” to the string “The brown fox jumped over the lazy dog” using required string manipulation functions.
            string stringAtoZ = "The quick fox Jumped Over the DOG";
            Console.WriteLine(stringAtoZ);
            stringAtoZ = stringAtoZ.Replace("quick", "brown");
            stringAtoZ = stringAtoZ.ToLower();
            stringAtoZ = stringAtoZ.Remove(0, 1).Insert(0, "T");
            Console.WriteLine(stringAtoZ);

            // Enter any two words from console and check whether they are same or not
            Console.WriteLine("Enter a word:");
            string wordOne = Console.ReadLine();
            Console.WriteLine("Enter a second word:");
            string wordTwo = Console.ReadLine();
            if (wordOne.Equals(wordTwo))
            {
                Console.WriteLine("The wordes you entered are the same.");
            }
            else
            {
                Console.WriteLine("The words you entered are NOT the same.");
            }

            // Input word Donkey and display it as the word Monkey.
            Console.WriteLine("Please enter the word Monkey:");
            string monkeyWord = Console.ReadLine();
            Console.WriteLine("Replaceing M with D: {0}", monkeyWord.Replace("M", "D"));
  
        }

        private static void RunExerciseSeven()
        {

        }
        private static void RunExerciseEight()
        {

        }
        private static void RunExerciseNine()
        {

        }

        static void Main(string[] args)
        {
            






           
            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
            }

        }

    }
}
