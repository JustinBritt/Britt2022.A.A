namespace Britt2022.A.A.VariableElements.Factories
{
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class IMaxVariableElementFactory : IIMaxVariableElementFactory
    {
        public IMaxVariableElementFactory()
        {
        }

        public IMaxVariableElement Create()
        {
            IMaxVariableElement variableElement;

            try
            {
                variableElement = new IMaxVariableElement();
            }
            finally
            {
            }

            return variableElement;
        }
    }
}