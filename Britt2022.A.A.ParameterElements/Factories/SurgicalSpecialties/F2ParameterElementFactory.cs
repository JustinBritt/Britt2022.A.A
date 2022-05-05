namespace Britt2022.A.A.ParameterElements.Factories.SurgicalSpecialties
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.SurgicalSpecialties;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;

    internal sealed class F2ParameterElementFactory : IF2ParameterElementFactory
    {
        public F2ParameterElementFactory()
        {
        }

        public F2ParameterElement Create()
        {
            F2ParameterElement parameterElement;

            try
            {
                parameterElement = new F2ParameterElement();
            }
            finally
            {
            }

            return parameterElement;
        }

        public F2ParameterElement Create(
            int value)
        {
            F2ParameterElement parameterElement;

            try
            {
                parameterElement = new F2ParameterElement(
                    value);
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}