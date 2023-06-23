using System;
using System.Threading.Channels;

namespace Basic_Concepts
{
    public class Program
    {
        // instance variable
        int a = 10;

        // static variable
        static int b = 20;

        // constant variable
        const float max = 50;

        // Creating Method for local variable
        public void StudentAge()
        {
            // local variable age
            int age = 0;

            age = age + 18;
            Console.WriteLine("Student age is : " + age);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a program to demonstrate types of variables present in c#");
            Program myObj = new Program();
            Console.Write("\nThe value of local variable, ");
            myObj.StudentAge();
            Console.WriteLine("The value of instance variable, a is = " + myObj.a);
            Console.WriteLine("The value of static variable, b is = " + Program.b);
            Console.WriteLine("The value of constant variable, max is = " + Program.max);
        }
    }
}