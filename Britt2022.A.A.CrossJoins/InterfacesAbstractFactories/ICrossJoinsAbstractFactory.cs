namespace Britt2022.A.A.CrossJoins.InterfacesAbstractFactories
{
    using Britt2022.A.A.CrossJoins.InterfacesFactories.Mappings;

    public interface ICrossJoinsAbstractFactory
    {
        IabMappingFactory CreateabMappingFactory();

        IabcMappingFactory CreateabcMappingFactory();

        IabcdMappingFactory CreateabcdMappingFactory();
    }
}