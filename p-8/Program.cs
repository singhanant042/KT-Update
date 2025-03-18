using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface I1
{
    void print();
}

interface I2
{
    void print();
}


public class Class:I1,I2
{
    void I1.print()
    {
        Console.WriteLine("I1");
    }

    void I2.print()
    {
        Console.WriteLine("I2");
    }
}
namespace p_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class C1 = new Class();
            ((I1)C1).print();
            ((I2)C1).print();
        }
    }
}
