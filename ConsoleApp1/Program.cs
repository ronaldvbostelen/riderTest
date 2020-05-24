using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new List<Car>
            {
                new Car("Daimler-AG", "Mercedec CLA"),
                new Car("Daimler-AG", "Mercedec C-Class"),
                new Car("Daimler-AG", "Mercedec A-Class")
            };

            foreach (var car in l)
            {
                Console.WriteLine(car);
            }
        }
    }
}