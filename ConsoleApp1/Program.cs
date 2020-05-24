using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var l = new List<Car>
            {
                new Car("Daimler-AG", "Mercedes", "CLA"),
                new Car("Daimler-AG", "Mercedes", "C-Class"),
                new Car("Daimler-AG", "Mercedes", "A-Class")
            };

            foreach (var car in l) Console.WriteLine(car);
        }
    }
}