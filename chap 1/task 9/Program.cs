using System;

namespace task_9
{
    class HelloCSharp
    {
        static void Main()
        {
            Console.Write("Enter age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("My age after 10 years will be {0}", age + 10);
        }
    }
}
