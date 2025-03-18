using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Customer
{
    public abstract void print();
    public void print_1()
    {
        Console.WriteLine("Another method");
    }
}


public class Class:Customer
{
    public  override void print()
    {
        Console.WriteLine("First Method from non-abstracrt class");
    }
}
namespace p_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class c1 = new Class();
            c1.print();
            c1.print_1();
        }
    }
}
