using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    public string namee;
    public int age;

    public void print()
    {
        Console.WriteLine("From Base");
    }
}


public class Full_time:Employee
{
    public  new void print()
    {
        Console.WriteLine("From Derived");
    }
}
namespace p_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Full_time f1 = new Full_time();
            f1.print();

        }
    }
}
