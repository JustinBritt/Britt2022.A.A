namespace Britt2022.A.A.ResultElements.InterfacesFactories.ScenarioRecoveryWardCensuses
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;

    public interface IIMaxResultElementFactory
    {
        IMaxResultElement Create(
            PositiveInt scenario,
            decimal value);
    }
}