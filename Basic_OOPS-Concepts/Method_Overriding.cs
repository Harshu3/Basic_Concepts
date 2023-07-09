using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Concepts
{
    public class Adding
    {
        public virtual void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum is: " + c);
        }
        public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine("Sum is: " + c);
        }
        public void Add(float a, int b, double c)
        {
            double d = a + b + c;
            Console.WriteLine("Sum is: " + d);
        }
    }
    
    public class Operation: Adding
    {
        public override void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of two integers is: " + c);
        }
    }
}
