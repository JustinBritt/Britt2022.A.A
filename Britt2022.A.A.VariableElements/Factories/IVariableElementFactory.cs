namespace Britt2022.A.A.VariableElements.Factories
{
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class IVariableElementFactory : IIVariableElementFactory
    {
        public IVariableElementFactory()
        {
        }

        public IVariableElement Create()
        {
            IVariableElement variableElement;

            try
            {
                variableElement = new IVariableElement();
            }
            finally
            {
            }

            return variableElement;
        }
    }
}