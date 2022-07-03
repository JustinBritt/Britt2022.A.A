namespace Britt2022.A.A.ParameterElements.Factories.SurgicalSpecialties
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.SurgicalSpecialties;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;

    internal sealed class B1ParameterElementFactory : IB1ParameterElementFactory
    {
        public B1ParameterElementFactory()
        {
        }

        public B1ParameterElement Create(
            int value)
        {
            B1ParameterElement parameterElement;

            try
            {
                parameterElement = new B1ParameterElement(
                    value);
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}