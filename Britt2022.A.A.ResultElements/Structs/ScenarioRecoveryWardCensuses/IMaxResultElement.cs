namespace Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses
{
    using Hl7.Fhir.Model;

    public struct IMaxResultElement
    {
        public IMaxResultElement(
            INullableValue<int> scenario,
            decimal value)
        {
            this.Scenario = scenario;

            this.Value = value;
        }

        public INullableValue<int> Scenario { get; }

        public decimal Value { get; }
    }
}