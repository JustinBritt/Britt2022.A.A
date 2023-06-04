namespace Britt2022.A.A.ResultElements.Structs.DayScenarioRecoveryWardCensuses
{
    using Hl7.Fhir.Model;

    public struct IResultElement
    {
        public IResultElement(
            FhirDateTime day,
            INullableValue<int> scenario,
            decimal value)
        {
            this.Day = day;

            this.Scenario = scenario;

            this.Value = value;
        }

        public FhirDateTime Day { get; }

        public INullableValue<int> Scenario { get; }

        public decimal Value { get; }
    }
}