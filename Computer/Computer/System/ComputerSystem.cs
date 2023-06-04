using System;
using System.Collections;
using System.Collections.Generic;
using Computer.ComputerElement;
using Computer.Visitor;

namespace Computer
{
    public class ComputerSystem : IComputerSystem
    {
        private readonly IEnumerable<IComputerElement> _computerElements;

        public ComputerSystem(IEnumerable<IComputerElement> computerElements) => 
            _computerElements = computerElements;

        public int GetComputerConsumption()
        {
            var visitor = new PowerConsumptionVisitor();
            
            foreach (var computerElement in _computerElements)
                computerElement.Accept(visitor);

            return visitor.TotalPowerConsumption;
        }

        public void ShowElements()
        {
            foreach (var computerElement in _computerElements) 
                Console.WriteLine(computerElement.Show());
        }
    }
}