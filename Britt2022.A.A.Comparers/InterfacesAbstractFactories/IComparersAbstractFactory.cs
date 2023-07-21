namespace Britt2022.A.A.Comparers.InterfacesAbstractFactories
{
    using Britt2022.A.A.Comparers.InterfacesFactories;

    public interface IComparersAbstractFactory
    {
        IFhirDateTimeComparerFactory CreateFhirDateTimeComparerFactory();

        ILocationComparerFactory CreateLocationComparerFactory();

        INullableValueintComparerFactory CreateNullableValueintComparerFactory();

        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}