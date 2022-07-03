namespace Britt2022.A.A.VariableElements.Factories
{
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class xVariableElementFactory : IxVariableElementFactory
    {
        public xVariableElementFactory()
        {
        }

        public xVariableElement Create(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int value)
        {
            xVariableElement variableElement;

            try
            {
                variableElement = new xVariableElement(
                    iIndexElement: iIndexElement,
                    jIndexElement: jIndexElement,
                    kIndexElement: kIndexElement,
                    value: value);
            }
            finally
            {
            }

            return variableElement;
        }
    }
}