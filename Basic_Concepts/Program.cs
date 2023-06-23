using System;
using System.Threading.Channels;

namespace Basic_Concepts
{
    public class Program
    {
        string brand = "Mahindra";
        string color = "Red";

        static void Main(string[] args)
        {
            Console.WriteLine("Create a program with object and class concept with example");
            Program myObj = new Program();
            Console.WriteLine("Car brand = " + myObj.brand);
            Console.WriteLine("Car color = " + myObj.color);
        }
    }
}