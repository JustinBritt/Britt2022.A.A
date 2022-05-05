namespace Britt2022.A.A.ParameterElements.Factories.StrategicTargets
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;

    internal sealed class NParameterElementFactory : INParameterElementFactory
    {
        public NParameterElementFactory()
        {
        }

        public NParameterElement Create()
        {
            NParameterElement parameterElement;

            try
            {
                parameterElement = new NParameterElement();
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}