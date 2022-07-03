namespace Britt2022.A.A.ParameterElements.Factories.Surgeries
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;

    internal sealed class AParameterElementFactory : IAParameterElementFactory
    {
        public AParameterElementFactory()
        {
        }

        public AParameterElement Create(
            int iIndexElement,
            int ωIndexElement,
            double value)
        {
            AParameterElement parameterElement;

            try
            {
                parameterElement = new AParameterElement(
                    iIndexElement: iIndexElement,
                    ωIndexElement: ωIndexElement,
                    value: value);
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}