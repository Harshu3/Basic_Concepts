using System;
using System.Threading.Channels;

namespace Basic_Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a program with Polymorphism concept with example in c#");
            Console.WriteLine("Output for Method Overloading");
            Addition add = new Addition();
            Console.WriteLine("Enter float value");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter integer value");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter double value");
            double z = Convert.ToDouble(Console.ReadLine());
            add.Add(x, y, z);

            Console.WriteLine("\nOutput for Method Overriding");
            Adding op = new Operation();
            op.Add(4, 5);
        }
    }
}