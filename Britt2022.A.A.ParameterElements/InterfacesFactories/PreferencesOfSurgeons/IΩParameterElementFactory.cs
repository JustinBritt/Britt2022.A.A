namespace Britt2022.A.A.ParameterElements.InterfacesFactories.PreferencesOfSurgeons
{
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;

    public interface IΩParameterElementFactory
    {
        ΩParameterElement Create(
            int iIndexElement,
            int kIndexElement,
            int value);
    }
}