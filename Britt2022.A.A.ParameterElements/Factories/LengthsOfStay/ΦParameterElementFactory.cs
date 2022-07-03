namespace Britt2022.A.A.ParameterElements.Factories.LengthsOfStay
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    internal sealed class ΦParameterElementFactory : IΦParameterElementFactory
    {
        public ΦParameterElementFactory()
        {
        }

        public ΦParameterElement Create(
            int iIndexElement,
            int lIndexElement,
            int ωIndexElement,
            double value)
        {
            ΦParameterElement parameterElement;

            try
            {
                parameterElement = new ΦParameterElement(
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