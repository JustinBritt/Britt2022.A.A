namespace Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets
{
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;

    public interface INParameterElementFactory
    {
        NParameterElement Create(
            int iIndexElement,
            int value);
    }
}