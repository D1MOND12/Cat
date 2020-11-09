using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("Василий Петрович", new DateTime(2000, 12, 12));
            c.MakeNoise();
            Console.WriteLine($"Коту {c.Name} {c.GetAge()} лет");
        }
    }
}