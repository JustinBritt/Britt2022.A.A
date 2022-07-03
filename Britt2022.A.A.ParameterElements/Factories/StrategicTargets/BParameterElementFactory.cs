namespace Britt2022.A.A.ParameterElements.Factories.StrategicTargets
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;

    internal sealed class BParameterElementFactory : IBParameterElementFactory
    {
        public BParameterElementFactory()
        {
        }

        public BParameterElement Create(
            int rIndexElement,
            int value)
        {
            BParameterElement parameterElement;

            try
            {
                parameterElement = new BParameterElement(
                    rIndexElement: rIndexElement,
                    value: value);
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}