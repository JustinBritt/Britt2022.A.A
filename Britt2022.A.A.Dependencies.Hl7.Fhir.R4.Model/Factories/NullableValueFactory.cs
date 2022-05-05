namespace Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.Factories
{
    using System;

    using global::Hl7.Fhir.Model;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;

    public sealed class NullableValueFactory : INullableValueFactory
    {
        public INullableValue<T> Create<T>(
            T? value)
            where T : struct
        {
            INullableValue<T> instance = null;

            try
            {
                PrimitiveType primitiveType = value switch
                {
                    bool b => new FhirBoolean(
                        b),

                    decimal d => new FhirDecimal(
                        d),

                    int i => new PositiveInt(
                        i),

                    { } => throw new ArgumentNullException(nameof(value)),

                    _ => null
                };

                instance = (INullableValue<T>)primitiveType;
            }
            finally
            {
            }

            return instance;
        }
    }
}