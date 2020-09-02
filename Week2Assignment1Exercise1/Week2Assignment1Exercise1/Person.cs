using System;
using System.Collections.Generic;

// Create class for persons, first name, lastname and age

public class Person
{
    private string userFirstName;
    private string userLastName;
    private int userAge;
    //private static int InstanceCount = 0;
    private int InstanceCount;

	public Person(string firstName, string lastName, int age) // Constructor
	{
        userFirstName = firstName;
        userLastName = lastName;
        userAge = age;
        InstanceCount = 0;
        IncreaseInstanceCount();
	}

    public void Speak()
    {
        Console.WriteLine("Hello my name is {0} {1}!", userFirstName, userLastName);
    }

    public override string ToString()
    {
        return String.Concat(userFirstName, userLastName, userAge);
        //return base.ToString();
    }

    private void IncreaseInstanceCount()
    {
        InstanceCount++;
    }

    public int GetInstanceCount()
    {
        return InstanceCount;
    }

    public string GetFirstname()
    {
        return userFirstName;
    }

    public string GetLastName()
    {
        return userLastName;
    }
}

// Exercise 1.6
// Create two subclasses, Employee and Customer

public class Employee : Person
{
    Person userEmployee;
    private int userSalary;
    List<Sale> saleList;


    // Exercise 1.7
    // Can't create Employee-object in the class, it will cause a stackoverflow
    //Employee david = new Employee("David", "Ewens", 30, 25000);
    //Customer gustav = new Customer("Gustav", "Wasa", 55);

    // 1.6
    // "Create constructors in both classes that calls the base Person class constructor passing the information it needs (see figure below)."
    public Employee(string firstName, string lastName, int age, int salary) : base(firstName, lastName, age)
    {
        userEmployee = new Person(firstName, lastName, age);
        userSalary = salary;

        saleList = new List<Sale>();

        // 1.7
        // Can't create object david in constructor, because it will loop and cause a stackoverflow
        //Sale saleOne = new Sale("Eggs", 3.14, david, gustav);
        //Sale saleOne = new Sale();
        //saleList.Add(saleOne);
        
    }

    public override string ToString()
    {
        return String.Concat("Employee: ", userEmployee.ToString(), " Salary: ", userSalary );
    }
    // 1.7
    
    public void AddSaleToList(string name, double price, Employee seller, Customer buyer)
    {
        saleList.Add(new Sale(name, price, seller, buyer));
    }
    // 1.8
    public int GetNumberOfSales()
    {
        return saleList.Count;
    }
    public double GetSalesTotal()
    {
        double totalSales = 0;
        for(int n = 0; n < saleList.Count; n++)
        {
            totalSales += saleList[n].getPrice();
        }
        return totalSales;
    }
    public double AverageSales()
    {
        double totalSales = 0;
        for (int n = 0; n < saleList.Count; n++)
        {
            totalSales += saleList[n].getPrice();
        }
        return totalSales/saleList.Count;
    }
    public void SalesStatistics()
    {
        Console.WriteLine("Following is statistics for {0} {1}!", userEmployee.GetFirstname(), userEmployee.GetLastName());
        Console.WriteLine("Number of Sales: {0}", GetNumberOfSales());
        Console.WriteLine("Sales total: ${0}", GetSalesTotal());
        Console.WriteLine("Average sales: ${0}", AverageSales());
    }
    public void ListOfSales()
    {
        Console.WriteLine("List of sales:\n");
        for (int n = 0; n < saleList.Count; n++)
        {
            Console.WriteLine("Product: {0} Price: {1} Buyer: {2} {3}", saleList[n].getProduct(), saleList[n].getPrice(), saleList[n].GetCustomer().GetCustomerFristName(), saleList[n].GetCustomer().GetCustomerLastName());
        }
    }
}

public class Customer : Person
{
    Person userCustomer;
    List<Sale> saleList;

    public Customer(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        userCustomer = new Person(firstName, lastName, age);
        saleList = new List<Sale>();

    }

    public override string ToString()
    {
        return String.Concat("Customer: ", userCustomer.ToString());
    }
    /*
    public void AddSaleToList(string name, double price, Employee seller, Customer buyer)
    {
        saleList.Add(new Sale(name, price, seller, buyer));
    }*/

    // 1.7
    public string GetCustomerFristName()
    {
        return userCustomer.GetFirstname();
    }
    public string GetCustomerLastName()
    {
        return userCustomer.GetLastName();
    }
}

// Exercise 1.7 

/*
 *  Add a property, list of sale objects, in Employee class and Customer class. Implement a collection of Sale objects in both classes’ constructors – Sales list and Purchase list.
 *   Implement a method in Sale class that adds a new sale to the lists.
 */
 // If the list is in Customer and Employee, then the add list method should also be in the same class. So i don't understan the last sentence.
 // i added a unneccesery AddSale to the Sale class

public class Sale
{
    private string nameOfProduct;
    private double priceOfProduct;
    Employee sellerEmployee;
    Customer buyerCustomer;
    DateTime transactionDate;

    public Sale() { }

    public Sale(string product, double price, Employee seller, Customer customer)
    {
        nameOfProduct = product;
        priceOfProduct = price;
        sellerEmployee = seller;
        buyerCustomer = customer;
        transactionDate = DateTime.Now;
    }

    public Sale AddSale(Sale newSale)
    {
        return newSale;
    }

    public double getPrice()
    {
        return priceOfProduct;
    }
    public string getProduct()
    {
        return nameOfProduct;
    }
    public Customer GetCustomer()
    {
        return buyerCustomer;
    }
}