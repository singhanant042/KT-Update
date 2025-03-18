using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public interface I_Customer
{
    void print();
    void print(string name);

}


public class Customer:I_Customer
{
    public void print()
    {
        Console.WriteLine("Welcome");
    }

    public void print(string name)
    {
        Console.WriteLine(name);
    }
}
namespace p_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer();
            c1.print();
            c1.print("Anant Singh");
        }
    }
}
