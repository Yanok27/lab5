using Computer.Visitor;

namespace Computer.ComputerElement
{
    public interface IComputerElement
    {
        int PowerConsumption { get; }
        void Accept(IVisitor visitor);
        string Show();
    }
}