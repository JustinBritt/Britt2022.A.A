namespace Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses
{
    using Hl7.Fhir.Model;

    public struct IMaxResultElement
    {
        public IMaxResultElement(
            PositiveInt scenario,
            decimal value)
        {
            this.Scenario = scenario;

            this.Value = value;
        }

        public PositiveInt Scenario { get; }

        public decimal Value { get; }
    }
}