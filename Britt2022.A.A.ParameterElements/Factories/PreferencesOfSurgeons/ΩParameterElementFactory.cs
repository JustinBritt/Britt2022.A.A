namespace Britt2022.A.A.ParameterElements.Factories.PreferencesOfSurgeons
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;

    internal sealed class ΩParameterElementFactory : IΩParameterElementFactory
    {
        public ΩParameterElementFactory()
        {
        }

        public ΩParameterElement Create(
            int iIndexElement,
            int kIndexElement,
            int value)
        {
            ΩParameterElement parameterElement;

            try
            {
                parameterElement = new ΩParameterElement(
                    iIndexElement: iIndexElement,
                    kIndexElement: kIndexElement,
                    value: value);
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}