using Computer.ComputerElement;

namespace Computer.Visitor
{
    public interface IVisitor
    {
        void VisitProcessor(Processor processor);
        void VisitMemory(Memory memory);
        void VisitGraphicsCard(GraphicsCard graphicsCard);
    }
}