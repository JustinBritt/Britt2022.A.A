namespace Britt2022.A.A.VariableElements.Factories
{
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class xVariableElementFactory : IxVariableElementFactory
    {
        public xVariableElementFactory()
        {
        }

        public xVariableElement Create()
        {
            xVariableElement variableElement;

            try
            {
                variableElement = new xVariableElement();
            }
            finally
            {
            }

            return variableElement;
        }
    }
}