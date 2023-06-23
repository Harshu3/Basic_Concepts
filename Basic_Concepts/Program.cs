using System;
using System.Threading.Channels;

namespace Basic_Concepts
{
    //Creating Static Class
    public static class StaticClass
    {
        //Creating Static Method
        public static void ReturnValue()
        {
            int a = 10, b = 20;
            int sum = a + b;
            Console.WriteLine("Sum is = " + sum);
        }
    }

    //Creating Abstract Class
    abstract class test1
    {
        //Creating Abstract Method
        public abstract int mul(int i, int j);
    }
    class test2 : test1
    {
        //Overriding Abstract Method
        public override int mul(int i, int j)
        {
            return i * j;
        }
    }
    public class Program
    {
        // Creating Instance Method
        public void StudentAge()
        {
            int age = 0;

            age = age + 18;
            Console.WriteLine("Student age is : " + age);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a program to demonstrate types of methods in c#");
            Program myObj = new Program();
            Console.WriteLine("\nOutput of Instance method");
            myObj.StudentAge();
            Console.WriteLine("\nOutput of Static method");
            StaticClass.ReturnValue();
            Console.WriteLine("\nOutput of Abstract method");
            test1 ob1 = new test2();
            int b = ob1.mul(4, 2);
            Console.WriteLine("4 * 2 = " + b);
        }
    }
}