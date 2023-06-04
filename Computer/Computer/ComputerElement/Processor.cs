using Computer.Visitor;

namespace Computer.ComputerElement
{
    public class Processor : IComputerElement
    {
        public int PowerConsumption { get; }

        public Processor(int powerConsumption)
        {
            PowerConsumption = powerConsumption;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitProcessor(this);
        }

        public string Show() => $"Processor: \n\tPowerConsumption: {PowerConsumption}";
    }
}