namespace Britt2022.A.A.ParameterElements.Factories.LengthsOfStay
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    internal sealed class hiParameterElementFactory : IhiParameterElementFactory
    {
        public hiParameterElementFactory()
        {
        }

        public hiParameterElement Create(
            int iIndexElement,
            int value)
        {
            hiParameterElement parameterElement;

            try
            {
                parameterElement = new hiParameterElement(
                    iIndexElement: iIndexElement,
                    value: value);
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}