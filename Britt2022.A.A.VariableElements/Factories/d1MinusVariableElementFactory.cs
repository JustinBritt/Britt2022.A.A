namespace Britt2022.A.A.VariableElements.Factories
{
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class d1MinusVariableElementFactory : Id1MinusVariableElementFactory
    {
        public d1MinusVariableElementFactory()
        {
        }

        public d1MinusVariableElement Create()
        {
            d1MinusVariableElement variableElement;

            try
            {
                variableElement = new d1MinusVariableElement();
            }
            finally
            {
            }

            return variableElement;
        }
    }
}