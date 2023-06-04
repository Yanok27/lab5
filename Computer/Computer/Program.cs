using System;
using System.Collections.Generic;
using Computer.ComputerElement;
using Computer.Locator;
using Computer.Visitor;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceLocator = new ServiceLocator();
            var computerSystem = serviceLocator.GetService<IComputerSystem>();

            computerSystem.ShowElements();
            Console.WriteLine("Computer total consumption: " + computerSystem.GetComputerConsumption());
        }
    }
}