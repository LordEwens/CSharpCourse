using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment1Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1.2
            Person newPerson = new Person("David", "Ewens", 30);
            newPerson.Speak();
            Console.ReadKey();

            // Exercise 1.3            
            Console.WriteLine(newPerson); // The result is the name of the class, "ExerciseOneDotOne".
            Console.ReadKey();

            // Exercise 1.4
            // Now, with the override of .ToString, a concat of first name, last name and age is printed

            // Exercise 1.5 
            // Create method for counting objects of ExerciseOneDotOne
            // "Where could you call the IncreaseInstanceCount method, so that it increases the InstanceCount each time we create a new person"
            // Answer: the constructor, it is called every time a new object is created
            Console.WriteLine("Instances of object: {0}", newPerson.GetInstanceCount());
            Console.ReadKey();

            // Exercise 1.6
            Employee bill = new Employee("Bill", "Gates", 50, 30000);
            Customer melinda = new Customer("Melinda", "Gates", 45);
            Console.WriteLine(melinda);
            Console.ReadKey();

            AboutPerson(bill);
            AboutPerson(melinda);
            Console.ReadKey();

            // Exercise 1.7
            bill.AddSaleToList("Butter", 3.14, bill, melinda);
            bill.AddSaleToList("Butter", 2, bill, melinda);
            // newCustomer.AddSaleToList("Eggs", 3.14, newEmployee, newCustomer);
            /*
            Console.WriteLine("Bill Nr. of sales: {0}", bill.GetNumberOfSales());
            Console.WriteLine("Bill Total sales: {0}", bill.GetSalesTotal());
            Console.WriteLine("Bill Average sales: {0}", bill.AverageSales());
            */
            bill.SalesStatistics();

            Console.ReadKey();

            bill.ListOfSales();

            Console.ReadKey();
        }

        // Create a new static method in your Program-class that takes a Person object as parameter.
        static void AboutPerson(Person n)
        {
            Console.WriteLine(n);
        }
    }
}
