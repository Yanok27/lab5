using System.Collections.Generic;
using Computer.ComputerElement;

namespace Computer.Data
{
    public interface IComputerElementData
    {
        IEnumerable<IComputerElement> ComputerElements { get; }
    }
}