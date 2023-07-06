using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Basic_Concepts
{
    public class Father
    {
        public void Car()
        {
            Console.WriteLine("Father is driving Car");
        }
    }
    public class Daughter: Father
    {
        public void Study()
        {
            Console.WriteLine("Daughter is Studying");
        }
    }
    public class Son: Father
    {
        public void Working()
        {
            Console.WriteLine("Son is Working");
        }
    }
}
