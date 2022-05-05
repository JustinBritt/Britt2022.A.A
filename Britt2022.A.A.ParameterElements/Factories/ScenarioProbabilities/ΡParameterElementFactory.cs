namespace Britt2022.A.A.ParameterElements.Factories.ScenarioProbabilities
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;

    internal sealed class ΡParameterElementFactory : IΡParameterElementFactory
    {
        public ΡParameterElementFactory()
        {
        }

        public ΡParameterElement Create()
        {
            ΡParameterElement parameterElement;

            try
            {
                parameterElement = new ΡParameterElement();
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}