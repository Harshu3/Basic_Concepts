using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Basic_Concepts
{
    public class GrandParent
    {
        public void Home()
        {
            Console.WriteLine("This is Home");
        }
    }
    public class Parent: GrandParent
    {
        public void Car()
        {
            Console.WriteLine("This is Car");
        }
    }
    public class Child: Parent
    {
        public void Game()
        {
            Console.WriteLine("Child is Playing Game");
        }
    }

}
