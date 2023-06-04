using System;
using Computer.Visitor;

namespace Computer.ComputerElement
{
    public class GraphicsCard : IComputerElement
    {
        public int PowerConsumption { get; }

        public GraphicsCard(int powerConsumption)
        {
            PowerConsumption = powerConsumption;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitGraphicsCard(this);
        }

        public string Show() => 
            $"Graphics Card: \n\tPowerConsumption: {PowerConsumption}";
    }
}