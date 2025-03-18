using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    public  string f_name = "FN";
    public  string l_name = "LN";

    public  virtual void print()
    {
        Console.WriteLine(f_name + " " + l_name);
    }
}

public class Full:Employee
{
    public override  void print()
    {
        Console.WriteLine(f_name +" "+l_name+" FTE");
    }
}

public class temp : Employee
{
    public override void print()
    {
        Console.WriteLine(f_name + " " + l_name + " temp");
    }
}
public class intern:Employee
{
    public override void print()
    {
        Console.WriteLine(f_name + " " + l_name + " Intern");
    }
}

public class contract:Employee
{
    public override void print()
    {
        Console.WriteLine(f_name + " " + l_name + " Contractor");
    }
}
namespace p_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee();
            //e1.print();
            //Full f1 = new Full();
            //f1.print();
            //temp t1 = new temp();
            //t1.print();

            Employee[] e = new Employee[4];
            e[0] = new Employee();
            e[1] = new Full();
            e[2] = new temp();
            e[3] = new intern();


            for(int i = 0; i < e.Length; i++)
            {
                e[i].print();
            }


        }
    }
}
