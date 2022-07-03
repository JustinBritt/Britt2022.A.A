namespace Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets
{
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;

    public interface ILParameterElementFactory
    {
        LParameterElement Create(
            int iIndexElement,
            int value);
    }
}