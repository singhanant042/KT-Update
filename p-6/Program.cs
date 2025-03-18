using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    public int id;
    public string name;


    public int ID
    {
        set
        {
              if(value < 0)
            {
                throw new Exception("Invalid");
            }

            this.id = value;
        }

        get
        {
            return this.id;
        }
    }


    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name is Invalid");
            }
            this.name = value;
        }

        get
        {
            return this.name;
        }
    }
}
namespace p_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            e1.ID = 10;
            Console.WriteLine(e1.ID);
            e1.Name = "Anant Singh";
            Console.WriteLine(e1.Name);
        }
    }
}
