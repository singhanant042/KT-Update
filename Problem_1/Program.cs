using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



public abstract class Calculate
{

    public abstract double  tri(int x, int y);
    public abstract int rect(int x, int y);
   
}

public class name
{
    public string f_name;
    public int age;

    public name(string name,int age)
    {
        this.f_name = name;
        this.age = age;
    }
}
public class area:Calculate
{
    
      public  override double  tri(int x,int y)
    {
        return    0.5 * y * x;
    }

    public override int rect(int x,int y)
    {
        return x * y;
    }
}
namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            area a1 = new area();
            Console.WriteLine(a1.tri(1, 3));

            name n1 = new name("Anant",23);
            Console.WriteLine(n1.f_name);

        }
    }
}
