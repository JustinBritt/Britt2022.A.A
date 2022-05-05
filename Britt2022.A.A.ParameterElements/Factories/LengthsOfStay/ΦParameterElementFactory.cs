namespace Britt2022.A.A.ParameterElements.Factories.LengthsOfStay
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    internal sealed class ΦParameterElementFactory : IΦParameterElementFactory
    {
        public ΦParameterElementFactory()
        {
        }

        public ΦParameterElement Create()
        {
            ΦParameterElement parameterElement;

            try
            {
                parameterElement = new ΦParameterElement();
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}