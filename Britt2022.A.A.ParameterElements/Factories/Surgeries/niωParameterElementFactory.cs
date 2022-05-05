namespace Britt2022.A.A.ParameterElements.Factories.Surgeries
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;

    internal sealed class niωParameterElementFactory : IniωParameterElementFactory
    {
        public niωParameterElementFactory()
        {
        }

        public niωParameterElement Create()
        {
            niωParameterElement parameterElement;

            try
            {
                parameterElement = new niωParameterElement();
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}