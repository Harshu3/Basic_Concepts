using System;
using System.Threading.Channels;

namespace Basic_Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a program with Inheritance concept with example in c#");
            Child child = new Child();
            child.Car();
            child.Home();
            child.Game();
        }
    }
}