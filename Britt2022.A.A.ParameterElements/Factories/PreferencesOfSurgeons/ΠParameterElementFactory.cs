namespace Britt2022.A.A.ParameterElements.Factories.PreferencesOfSurgeons
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;

    internal sealed class ΠParameterElementFactory : IΠParameterElementFactory
    {
        public ΠParameterElementFactory()
        {
        }

        public ΠParameterElement Create(
            int iIndexElement,
            int jIndexElement,
            int value)
        {
            ΠParameterElement parameterElement;

            try
            {
                parameterElement = new ΠParameterElement(
                    iIndexElement: iIndexElement,
                    jIndexElement: jIndexElement,
                    value: value);
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}