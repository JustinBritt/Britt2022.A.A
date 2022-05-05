namespace Britt2022.A.A.ParameterElements.Factories.LengthsOfStay
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    internal sealed class pParameterElementFactory : IpParameterElementFactory
    {
        public pParameterElementFactory()
        {
        }

        public pParameterElement Create()
        {
            pParameterElement parameterElement;

            try
            {
                parameterElement = new pParameterElement();
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}