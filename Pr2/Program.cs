using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выводит на экран кол-во аргументов командной строки
            System.Console.WriteLine(args.Length);
            // Keep the console window open in debug mode...
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
