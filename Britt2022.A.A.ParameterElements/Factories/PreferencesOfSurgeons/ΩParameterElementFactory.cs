namespace Britt2022.A.A.ParameterElements.Factories.PreferencesOfSurgeons
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;

    internal sealed class ΩParameterElementFactory : IΩParameterElementFactory
    {
        public ΩParameterElementFactory()
        {
        }

        public ΩParameterElement Create()
        {
            ΩParameterElement parameterElement;

            try
            {
                parameterElement = new ΩParameterElement();
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}