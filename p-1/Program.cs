using System;


public class  Customer
{
    public string name;
    public int age;


    public Customer()
    {
        Console.WriteLine("First Cons");
    }
    public Customer(string msg)
    {
        Console.WriteLine(msg);
    }
    public void print()
    {
        Console.WriteLine(this.name);
    }
}

public class Employee:Customer
{
      public Employee():base("hhhhhhh")
    {
        Console.WriteLine("Child Cons");
    }
}


namespace p_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            e1.name = "Anant";
            e1.print();
        }
    }
}
