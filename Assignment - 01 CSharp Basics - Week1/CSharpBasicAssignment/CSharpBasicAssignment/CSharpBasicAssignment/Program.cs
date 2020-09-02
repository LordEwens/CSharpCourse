// Creator: David Ewens, Class 7A

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private static int RunExerciseThree()
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
            return (int)(age.TotalDays / 365); // Return is used by exercise 13
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
            // Nalini said that the string exercise was optional

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
            // Use appropriate order of precedence to get following result using formula x + y * z / m
            // e = 100, f=60, g=73. (what about h?)
            int x = 40, y = 20, z = 25, m = 15;
            int e, f, g;

            // 40 + 20 * 25 / 15
            // Normaly in mathematics, exponents and root extractions have precident, then multiplication and division, last addition and subtraction
            // If there are multiple multiplication and divisions, the order is left to right
            // I would solve the formula normaly like this, 40 + ((20 * 25)/15) = 73,3333

            e = ((x + y) * z) / m;
            f = (x + y) * (z / m); // Works because (z / m) = 1 when datatype is int
            g = (int)(x + (double)((y * z) / m));

            Console.WriteLine("E = {0} F = {1} G = {2}", e, f, g);

        }
        private static void RunExerciseEight()
        {
            Console.WriteLine("Please enter a positive integer:");
            int oddOrEven = Convert.ToInt32(Console.ReadLine());
            if (Convert.ToBoolean(oddOrEven % 2)) // 0 equals false, 1 equals true
            {
                Console.WriteLine("The integer is odd!");
            }
            else
            {
                Console.WriteLine("The integer is even!");
            }
        }
        private static void RunExerciseNine()
        {
            // Generate and store 20 random integer numbers in a list and separate those numbers in to two new lists. One even, one odd

            List<int> oddAndEven = new List<int>();
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            Random rnd = new Random();
   
            for (int n = 0; n < 20; n++)
            {
                oddAndEven.Add(rnd.Next(1000));
            }

            for(int n = 0; n < oddAndEven.Count; n++)
            {
                if (Convert.ToBoolean(oddAndEven[n] % 2))
                {
                    odd.Add(oddAndEven[n]);
                }
                else
                {
                    even.Add(oddAndEven[n]);
                }
            }

            
            Console.WriteLine("Odd:");
            for(int n = 0; n < odd.Count; n++)
            {
              Console.WriteLine(odd[n]);
            }
            Console.WriteLine("Even:");
            for (int n = 0; n < even.Count; n++)
            {
                Console.WriteLine(even[n]);
            }


        }
        private static void RunExercise10() // Optional
        {
        }
        private static void RunExercise11()
        {
            // Ask user to enter any 10 numbers and store in array, print only negative numbers on the console
            Console.WriteLine("Please enter 10 numbers:");
            int[] intArray = new int[10]; // C++/Java (int intArray[10];) Syntax for Arrays does not work in C#
            for (int n = 0; n < 10; n++)
            {
                intArray[n] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number:");
            for (int n = 0; n < 10; n++)
            {
                if(intArray[n] < 0)
                {
                    Console.WriteLine(intArray[n]);
                }
            }
        }
        private static void RunExercise12()
        {
            // Ask user for body temperature in Celsius, tell the user if he has a fever or not
            // Normal human body temperature is between 37.2 and 38.3 - a fever typically does not go higher than 41-42
            Console.WriteLine("What is your body temperature? (in Celsius)");
            int temp = int.Parse(Console.ReadLine());
            if (temp > 38 && temp < 43)
            {
                Console.WriteLine("You have a fever.");
            }
            else if (temp == 37 || temp == 38)
            {
                Console.WriteLine("Your body temperature is normal.");
            }
            else
            {
                Console.WriteLine("Your bodytemperature is not within the range of a fever or within normal body temperature!");
            }
        }
        private static void RunExercise13()
        {
            Console.WriteLine("Please enter your name:");
            string nameOfUser = Console.ReadLine();
            Console.WriteLine("Hello {0}! Please verify that you are 18 or older by entering your date of birth.", nameOfUser);

            int age = RunExerciseThree();

            if (age >= 18)
            {
                Console.WriteLine("Would you want to order a beer? (yes/no)");
                string orderBeer = Console.ReadLine();
                if (orderBeer == "yes") {
                    Console.WriteLine("Here is your beer!");
                }
                if (orderBeer == "no")
                {
                    Console.WriteLine("Would you like to order a coke? (yes/no)");
                    string orderCoke = Console.ReadLine();
                    if (orderCoke == "yes")
                    {
                        Console.WriteLine("Here is your coke!");
                    }
                    if (orderCoke == "no")
                    {
                        Console.WriteLine("Okay. No more options are avalible.");
                    }
                }
            }
            else if (age < 18)
            {
                Console.WriteLine("Would you like to order a coke? (yes/no)");
                string orderCoke = Console.ReadLine();
                if (orderCoke == "yes") {
                    Console.WriteLine("Here is your coke!");
                }
                if (orderCoke == "no") {
                    Console.WriteLine("Okay. No more options are avalible.");
                }
            }

        }
        private static void RunExercise14() // Optional
        {
        }
        private static void RunExercise15()
        {
            // Ask user for grade of exam and print relevant message (A-F)
            Console.WriteLine("What grade did you get on your exam? (A-F)");
            string gradeExam = Console.ReadLine();
            switch(gradeExam)
            {
                case "A":
                    Console.WriteLine("Wow! Good job!");
                    break;
                case "B":
                    Console.WriteLine("Thats a good grade!");
                    break;
                case "C":
                    Console.WriteLine("Okay. Avarege grade.");
                    break;
                case "E":
                    Console.WriteLine("You should study more.");
                    break;
                case "F":
                    Console.WriteLine("Have you been sleeping in class? Study more!");
                    break;
            }
        }
        private static void RunExercise16()
        {
            // Ask user to enter any number smaller than 100, print all values from 1 to number in ascending and descending order - use while and do-while
            Console.WriteLine("Enter number: (max 100)");
            int enterNumber = int.Parse(Console.ReadLine());

            int n = 1;
            while(n <= enterNumber) 
            {
                Console.WriteLine("{0}", n);
                n++;
            }

            do 
            {
                Console.WriteLine("{0}", enterNumber);
                enterNumber--;
            } while(enterNumber >= 1);

        }
        private static void RunExercise17()
        {
            // Print a math (multiplication) table 1-10
            for (int n = 1; n <= 10; n++)
            { 
                for(int m = 1; m <= 10; m++)
                {
                    Console.Write("{0}\t", m*n);
                }
                Console.Write("\n");
            }
        }
        private static void RunExercise18() // Optional
        {
        }
        private static void RunExercise19()
        {
            // Generate secret number and, let user guess number, if guess is wrong - ask user if he/she wants to guess again
            Random rnd = new Random();
            int secret = rnd.Next(10);

            while (true)
            {
                Console.WriteLine("Please guess secret number: (1-10)");
                int guess = int.Parse(Console.ReadLine());
                if (guess == secret) {
                    Console.WriteLine("Correct!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Wrong. Would you like to guess again? (yes/no)");
                    string yesOrNo = Console.ReadLine();
                    if(yesOrNo == "yes")
                    {
                        continue;
                    }
                    if(yesOrNo == "no")
                    {
                        break;
                    }
                }
            }

        }
        private static void RunExercise20() // Optional
        {
        }
        private static void RunExercise21() // Optional
        {
        }
        private static void RunExercise22() // Optional
        {
        }
        private static void RunExercise23() 
        {
            // Calculate area of triangle with user inputs, height and width/base (a = (b*h)/2)
            Console.WriteLine("Please enter height of triangle:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter base of triangle:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of triangle: {0}", (double)(b * h) / 2);

        }
        private static void RunExercise24()
        {
            // Write a program to add 2, 3 and 4 float values using AddNumbers method (all three methods using the same name), pass these float values as a parameter, print result inside method
            // Note - fist i was looking for a function named AddNumbers, but the exercise must be to create a overloaded function/method

            float one = (float)1.1, two = (float)1.3, three = (float)1.5, four = (float)1.7;
            AddNumbers(one, two);
            AddNumbers(one, two, three);
            AddNumbers(one, two, three, four);
        }
        public static void AddNumbers(float one, float two)
        {
            Console.WriteLine("{0}", one + two);
        }
        public static void AddNumbers(float one, float two, float three)
        {
            Console.WriteLine("{0}", one + two + three);
        }
        public static void AddNumbers(float one, float two, float three, float four)
        {
            Console.WriteLine("{0}", one + two + three + four);
        }
        private static void RunExercise25() // Optional
        {
        }
        private static void RunExercise26() 
        {
            // Write a swap function for swapping two numbers. Pass values as a parameter. Print the swapped values inside function as well at the next line where you called this function.
            int x = 1, y = 2;
            int[] intArray = SwapInt(x, y);
            Console.WriteLine("X: {0} Y: {1}", intArray[0], intArray[1]);
            // I'm not 100% sure this is the correct solution
        }
        public static int[] SwapInt(int nOne, int nTwo)
        { 
            int nTemp = nOne;
            nOne = nTwo;
            nTwo = nTemp;
            Console.WriteLine("nOne: {0} nTwo: {1}", nOne, nTwo);
            int[] intArray = new int[2];
            intArray[0] = nOne;
            intArray[1] = nTwo;
            return intArray;
        }
        private static void RunExercise27() 
        {
            // Same as 26 - but pass values as a parameter using ref type (ref is a keyword in CSharp)
            int x = 1, y = 2;
            SwapIntRef(ref x, ref y);
            Console.WriteLine("X: {0} Y: {1}", x, y);
        }
        public static void SwapIntRef(ref int nOne, ref int nTwo)
        {
            int nTemp = nOne;
            nOne = nTwo;
            nTwo = nTemp;
            Console.WriteLine("nOne: {0} nTwo: {1}", nOne, nTwo);
            return;
        }
        private static void RunExercise28() 
        {
            // Let user input string, check if its a palindrome
            Console.WriteLine("Please enter a string:");
            string palendrome = Console.ReadLine();

            bool isPalendrome = false;
            int lengthMinusN;

            for(int n = 0; n < palendrome.Length; n++)
            {
                lengthMinusN = (palendrome.Length - n) - 1;
                if (palendrome[n] == palendrome[lengthMinusN])
                {
                    isPalendrome = true;
                }
                else {
                    isPalendrome = false;
                    break;
                }
            }
            if(isPalendrome == true)
            {
                Console.WriteLine("The string is a palendrome.");
            }
            else 
            {
                Console.WriteLine("The string is NOT a palendrome.");
            }
        }
        private static void RunExercise29() 
        {
            // Ask user for twelve positive integers. Store in array. Display all - then separate into odd and even arrays
            Console.WriteLine("Please enter twelve integers:");
            int[] array = new int[12], arrayOdd = new int[12], arrayEven = new int[12];
            for (int n = 0; n < 12; n++)
            {
                array[n] = int.Parse(Console.ReadLine());
            }

            Console.Write("\n");
            int oddCount = 0, evenCount = 0;

            for (int n = 0; n < 12; n++)
            {
                Console.WriteLine(array[n]);
                if(Convert.ToBoolean(array[n] % 2)) // Odd
                {
                    arrayOdd[oddCount] = array[n];
                    oddCount++;
                }
                else // Even
                {
                    arrayEven[evenCount] = array[n];
                    evenCount++;
                }
            }

            Console.Write("\n");

            for (int n = 0; n < oddCount; n++)
            {
                Console.WriteLine(arrayOdd[n]);
            }

            Console.Write("\n");

            for (int n = 0; n < evenCount; n++)
            {
                Console.WriteLine(arrayEven[n]);
            }

        }
        private static void RunExercise30() // Optional
        {
        }
        private static void RunExercise31() // Optional
        {
        }
        private static void RunExercise32() // Optional
        {
        }
        private static void RunExercise33() 
        {
            // show min, max and avarege
            Console.WriteLine("Please enter a string of numbers. Seperated by comma. (1,2,34,83,19,45)");
            string numberString = Console.ReadLine();
            string[] numbers = numberString.Split(',');
            int min = 0, max = 0, ave = 0;
            for(int n = 0; n < numbers.Length; n++) 
            {
                if(n == 0)
                {
                    min = int.Parse(numbers[n]);
                    max = int.Parse(numbers[n]);
                }

                if(min > int.Parse(numbers[n]))
                {
                    min = int.Parse(numbers[n]);
                }

                if(max < int.Parse(numbers[n]))
                {
                    max = int.Parse(numbers[n]);
                }
                ave += int.Parse(numbers[n]);
            }
            Console.WriteLine("Min: {0} Max: {1} Ave: {2}", min, max, (double)ave / numbers.Length);
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
                        case -1:
                            keepAlive = false;
                            break;
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
                        case 10:
                            RunExercise10();
                            break;
                        case 11:
                            RunExercise11();
                            break;
                        case 12:
                            RunExercise12();
                            break;
                        case 13:
                            RunExercise13();
                            break;
                        case 14:
                            RunExercise14();
                            break;
                        case 15:
                            RunExercise15();
                            break;
                        case 16:
                            RunExercise16();
                            break;
                        case 17:
                            RunExercise17();
                            break;
                        case 18:
                            RunExercise18();
                            break;
                        case 19:
                            RunExercise19();
                            break;
                        case 20:
                            RunExercise20();
                            break;
                        case 21:
                            RunExercise21();
                            break;
                        case 22:
                            RunExercise22();
                            break;
                        case 23:
                            RunExercise23();
                            break;
                        case 24:
                            RunExercise24();
                            break;
                        case 25:
                            RunExercise25();
                            break;
                        case 26:
                            RunExercise26();
                            break;
                        case 27:
                            RunExercise27();
                            break;
                        case 28:
                            RunExercise28();
                            break;
                        case 29:
                            RunExercise29();
                            break;
                        case 30:
                            RunExercise30();
                            break;
                        case 31:
                            RunExercise31();
                            break;
                        case 32:
                            RunExercise32();
                            break;
                        case 33:
                            RunExercise33();
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
