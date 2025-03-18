using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    public string name;
    public int age;


    public void set_age(int age)
    {
        if(age < 0)
        {
            throw new Exception("Age cannot be negative");
        }
        this.age = age;
    }
    public int get_age()
    {
        return this.age;
    }


    public void set_name(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name is invalid");
        }
        this.name = name;
    }

    public string get_name()
    {
        return this.name;
    } 

   
}
namespace p_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            e1.set_age(12);
            Console.WriteLine("Age={0}", e1.get_age());

            e1.set_name("Anant Singh");
            Console.WriteLine(e1.get_name());
        }
    }
}
