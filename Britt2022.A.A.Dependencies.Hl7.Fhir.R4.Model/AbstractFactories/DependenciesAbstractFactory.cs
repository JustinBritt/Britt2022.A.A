namespace Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.AbstractFactories
{
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.Factories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;

    public sealed class DependenciesAbstractFactory : IDependenciesAbstractFactory
    {
        public DependenciesAbstractFactory()
        {
        }

        public INullableValueFactory CreateNullableValueFactory()
        {
            INullableValueFactory factory = null;

            try
            {
                factory = new NullableValueFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}