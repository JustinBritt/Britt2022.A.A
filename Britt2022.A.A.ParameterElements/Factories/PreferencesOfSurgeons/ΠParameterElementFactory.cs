namespace Britt2022.A.A.ParameterElements.Factories.PreferencesOfSurgeons
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;

    internal sealed class ΠParameterElementFactory : IΠParameterElementFactory
    {
        public ΠParameterElementFactory()
        {
        }

        public ΠParameterElement Create()
        {
            ΠParameterElement parameterElement;

            try
            {
                parameterElement = new ΠParameterElement();
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}