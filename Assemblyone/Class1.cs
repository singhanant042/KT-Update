using System;
using Assemblytwo;

namespace Assemblyone
{
    public class Assemblyoneclass1: Assemblytwoclass1
    {
        public void print()
        {
            //Assemblytwoclass1 a1 = new Assemblytwoclass1();
            base.id = 10;
            
        }
    }
}
