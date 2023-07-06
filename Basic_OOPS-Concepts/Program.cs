using System;
using System.Threading.Channels;

namespace Basic_Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a program with Inheritance concept with example in c#");
            Son son = new Son();
            son.Car();
            son.Working();
            Daughter dam = new Daughter();
            dam.Car();
            dam.Study();
        }
    }
}