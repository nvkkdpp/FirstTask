using System;

namespace _111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");

            string name = Console.ReadLine();

            Console.WriteLine("Привет, " + name);

            Console.WriteLine("Нажмите <enter> для выхода . . .");

            Console.Read();
        }
    }
}
