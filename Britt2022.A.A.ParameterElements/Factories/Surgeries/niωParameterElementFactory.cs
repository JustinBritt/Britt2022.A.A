namespace Britt2022.A.A.ParameterElements.Factories.Surgeries
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;

    internal sealed class niωParameterElementFactory : IniωParameterElementFactory
    {
        public niωParameterElementFactory()
        {
        }

        public niωParameterElement Create(
            int iIndexElement,
            int ωIndexElement,
            int value)
        {
            niωParameterElement parameterElement;

            try
            {
                parameterElement = new niωParameterElement(
                    iIndexElement: iIndexElement,
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