using Computer.ComputerElement;

namespace Computer.Visitor
{
    public class PowerConsumptionVisitor : IVisitor
    {
        public int TotalPowerConsumption { get; private set; }

        public void VisitProcessor(Processor processor) => 
            TotalPowerConsumption += processor.PowerConsumption;

        public void VisitMemory(Memory memory) => 
            TotalPowerConsumption += memory.PowerConsumption;

        public void VisitGraphicsCard(GraphicsCard graphicsCard) => 
            TotalPowerConsumption += graphicsCard.PowerConsumption;
    }
}