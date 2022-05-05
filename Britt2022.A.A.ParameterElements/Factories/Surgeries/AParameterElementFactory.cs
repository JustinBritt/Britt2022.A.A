namespace Britt2022.A.A.ParameterElements.Factories.Surgeries
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;

    internal sealed class AParameterElementFactory : IAParameterElementFactory
    {
        public AParameterElementFactory()
        {
        }

        public AParameterElement Create()
        {
            AParameterElement parameterElement;

            try
            {
                parameterElement = new AParameterElement();
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}