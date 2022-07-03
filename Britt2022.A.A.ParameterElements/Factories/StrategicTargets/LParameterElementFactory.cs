namespace Britt2022.A.A.ParameterElements.Factories.StrategicTargets
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;

    internal sealed class LParameterElementFactory : ILParameterElementFactory
    {
        public LParameterElementFactory()
        {
        }

        public LParameterElement Create(
            int iIndexElement,
            int value)
        {
            LParameterElement parameterElement;

            try
            {
                parameterElement = new LParameterElement(
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