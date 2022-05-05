namespace Britt2022.A.A.VariableElements.Factories
{
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class IMinVariableElementFactory : IIMinVariableElementFactory
    {
        public IMinVariableElementFactory()
        {
        }

        public IMinVariableElement Create()
        {
            IMinVariableElement variableElement;

            try
            {
                variableElement = new IMinVariableElement();
            }
            finally
            {
            }

            return variableElement;
        }
    }
}