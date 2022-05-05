namespace Britt2022.A.A.VariableElements.InterfacesAbstractFactories
{
    using Britt2022.A.A.VariableElements.InterfacesFactories;

    public interface IVariableElementsAbstractFactory
    {
        Id1MinusVariableElementFactory Created1MinusVariableElementFactory();

        Id1PlusVariableElementFactory Created1PlusVariableElementFactory();

        Id2MinusVariableElementFactory Created2MinusVariableElementFactory();

        IIMaxVariableElementFactory CreateIMaxVariableElementFactory();

        IIMinVariableElementFactory CreateIMinVariableElementFactory();

        IIVariableElementFactory CreateIVariableElementFactory();

        IxVariableElementFactory CreatexVariableElementFactory();
    }
}