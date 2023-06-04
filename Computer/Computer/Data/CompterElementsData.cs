using System.Collections.Generic;
using Computer.ComputerElement;

namespace Computer.Data
{
    public class ComputerElementsData : IComputerElementData
    {
        private readonly List<IComputerElement> _computerElements;
        
        public IEnumerable<IComputerElement> ComputerElements => _computerElements;

        public ComputerElementsData()
        {
            _computerElements = new List<IComputerElement>()
            {
                new Memory(10),
                new Processor(15),
                new GraphicsCard(100)
            };
        }
    }
}