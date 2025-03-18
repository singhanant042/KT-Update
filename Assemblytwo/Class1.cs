using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assemblytwo
{
    public class Assemblytwoclass1
    {
        protected internal int id = 10;

    }

    public class Assemblytwolclass2
    {
        public void print()
        {
            Assemblytwoclass1 a1 = new Assemblytwoclass1();
            Console.WriteLine(a1.id);
        }
    }
}
