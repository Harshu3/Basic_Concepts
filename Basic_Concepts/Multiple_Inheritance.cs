using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Basic_Concepts
{
    public interface IMother
    {
        void Saree();
    }
    public class Father
    {
        public void Car()
        {
            Console.WriteLine("Car");
        }
    }
    public class Daughter: Father, IMother
    {
        public void Saree()
        {
            Console.WriteLine("Saree");
        }
    }

}
