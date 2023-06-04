using Computer.Visitor;

namespace Computer.ComputerElement
{
    public class Memory : IComputerElement
    {
        public int PowerConsumption { get; }

        public Memory(int powerConsumption) => 
            PowerConsumption = powerConsumption;

        public void Accept(IVisitor visitor) => 
            visitor.VisitMemory(this);

        public string Show()
            => $"Memory: \n\tPowerConsumption: {PowerConsumption}";
        
    }
}