namespace Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets
{
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;

    public interface IHParameterElementFactory
    {
        HParameterElement Create(
            int iIndexElement,
            int value);
    }
}