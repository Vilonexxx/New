using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет,друг! как тебя зовут?");
            var name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);
            Console.ReadLine();
        }
    }
}
