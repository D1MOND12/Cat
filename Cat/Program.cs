using System;
using System.Collections.Generic;

namespace Cat

{

    class Program

    {

        static void Main(string[] args)

        {

            Cat c = new Cat("Василий Петрович", new DateTime(2000, 12, 12));

            c.MakeNoise();

            Console.WriteLine($"Кошке по имени {c.Name} уже {c.GatAge()} лет");

            Cat ct = new Cat("Петр Василич", new DateTime(2003, 12, 12));

            ct.MakeNoise();

            Console.WriteLine($"Кошке по имени {ct.Name} уже {ct.GatAge()} лет");

            CatSmartHouse catSmartH = new CatSmartHouse(1000);

            catSmartH.AddCat(c);

            catSmartH.AddCat(ct);

            Console.ReadLine();//123

        }

    }

}