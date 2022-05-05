namespace Britt2022.A.A.Variables.InterfacesAbstractFactories
{
    using Britt2022.A.A.Variables.InterfacesFactories;

    public interface IVariablesAbstractFactory
    {
        Id1MinusFactory Created1MinusFactory();

        Id1PlusFactory Created1PlusFactory();

        Id2MinusFactory Created2MinusFactory();

        IIMaxFactory CreateIMaxFactory();

        IIMinFactory CreateIMinFactory();

        IIFactory CreateIFactory();

        IxFactory CreatexFactory();
    }
}