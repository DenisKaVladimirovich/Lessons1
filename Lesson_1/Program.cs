using System;
using System.Threading;

namespace Lesson_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Thread.Sleep(3000);
            Console.WriteLine("Привет, {0}, {1}, {2}, {3}", name, "Maria", "Vladislav", "Ivan");
            Console.ReadKey();
        }
    }
}
