namespace Britt2022.A.A.ParameterElements.Factories.StrategicTargets
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;

    internal sealed class NParameterElementFactory : INParameterElementFactory
    {
        public NParameterElementFactory()
        {
        }

        public NParameterElement Create(
            int iIndexElement,
            int value)
        {
            NParameterElement parameterElement;

            try
            {
                parameterElement = new NParameterElement(
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