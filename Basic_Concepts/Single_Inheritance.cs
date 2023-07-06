using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Basic_Concepts
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
    public class Dog: Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
}
