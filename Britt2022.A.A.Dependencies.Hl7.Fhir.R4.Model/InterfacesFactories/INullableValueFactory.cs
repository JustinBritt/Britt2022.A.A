namespace Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories
{
    using global::Hl7.Fhir.Model;

    public interface INullableValueFactory
    {
        INullableValue<T> Create<T>(
            T? value)
            where T : struct;
    }
}