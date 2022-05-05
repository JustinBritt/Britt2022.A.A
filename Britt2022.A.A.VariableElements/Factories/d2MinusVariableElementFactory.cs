namespace Britt2022.A.A.VariableElements.Factories
{
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class d2MinusVariableElementFactory : Id2MinusVariableElementFactory
    {
        public d2MinusVariableElementFactory()
        {
        }

        public d2MinusVariableElement Create()
        {
            d2MinusVariableElement variableElement;

            try
            {
                variableElement = new d2MinusVariableElement();
            }
            finally
            {
            }

            return variableElement;
        }
    }
}