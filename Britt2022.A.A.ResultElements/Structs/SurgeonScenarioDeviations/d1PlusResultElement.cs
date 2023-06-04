namespace Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations
{
    using Hl7.Fhir.Model;

    public struct d1PlusResultElement
    {
        public d1PlusResultElement(
            Organization surgeon,
            INullableValue<int> scenario,
            int value)
        {
            this.Surgeon = surgeon;

            this.Scenario = scenario;

            this.Value = value;
        }

        public Organization Surgeon { get; }

        public INullableValue<int> Scenario { get; }

        public int Value { get; }
    }
}