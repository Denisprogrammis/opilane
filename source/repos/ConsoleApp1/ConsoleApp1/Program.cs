using System;

namespace ConsoleApp1
{
    class Program
    {
        enum En
        {
            Fitst = 15,
            Second,
            Third = 54
        }
        static void Main(string[] args)
        {
            Console.WriteLine((int)En.Second);
            Console.ReadLine();
        }
    }
}
    
