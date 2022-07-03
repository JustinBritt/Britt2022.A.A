namespace Britt2022.A.A.ParameterElements.InterfacesFactories.PreferencesOfSurgeons
{
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;

    public interface IΠParameterElementFactory
    {
        ΠParameterElement Create(
            int iIndexElement,
            int jIndexElement,
            int value);
    }
}