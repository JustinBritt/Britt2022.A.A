namespace Britt2022.A.A.ParameterElements.Factories.ScenarioProbabilities
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;

    internal sealed class ΡParameterElementFactory : IΡParameterElementFactory
    {
        public ΡParameterElementFactory()
        {
        }

        public ΡParameterElement Create(
            int ωIndexElement,
            double value)
        {
            ΡParameterElement parameterElement;

            try
            {
                parameterElement = new ΡParameterElement(
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