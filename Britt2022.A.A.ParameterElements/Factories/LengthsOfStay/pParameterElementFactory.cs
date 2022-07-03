namespace Britt2022.A.A.ParameterElements.Factories.LengthsOfStay
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    internal sealed class pParameterElementFactory : IpParameterElementFactory
    {
        public pParameterElementFactory()
        {
        }

        public pParameterElement Create(
            int iIndexElement,
            int lIndexElement,
            int ωIndexElement,
            double value)
        {
            pParameterElement parameterElement;

            try
            {
                parameterElement = new pParameterElement(
                    iIndexElement: iIndexElement,
                    lIndexElement: lIndexElement,
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