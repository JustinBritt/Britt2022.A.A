namespace Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations
{
    using Hl7.Fhir.Model;

    public struct d1MinusResultElement
    {
        public d1MinusResultElement(
            Organization surgeon,
            PositiveInt scenario,
            int value)
        {
            this.Surgeon = surgeon;

            this.Scenario = scenario;

            this.Value = value;
        }

        public Organization Surgeon { get; }

        public PositiveInt Scenario { get; }

        public int Value { get; }
    }
}