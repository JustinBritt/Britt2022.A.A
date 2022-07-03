namespace Britt2022.A.A.ParameterElements.InterfacesFactories.Surgeries
{
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;

    public interface IAParameterElementFactory
    {
        AParameterElement Create(
            int iIndexElement,
            int ωIndexElement,
            double value);
    }
}