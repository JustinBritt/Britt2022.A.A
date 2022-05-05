namespace Britt2022.A.A.VariableElements.Factories
{
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;

    public sealed class d1PlusVariableElementFactory : Id1PlusVariableElementFactory
    {
        public d1PlusVariableElementFactory()
        {
        }

        public d1PlusVariableElement Create()
        {
            d1PlusVariableElement variableElement;

            try
            {
                variableElement = new d1PlusVariableElement();
            }
            finally
            {
            }

            return variableElement;
        }
    }
}