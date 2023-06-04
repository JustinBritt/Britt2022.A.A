namespace Britt2022.A.A.ResultElements.Factories.DayScenarioRecoveryWardCensuses
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.InterfacesFactories.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.DayScenarioRecoveryWardCensuses;

    internal sealed class IResultElementFactory : IIResultElementFactory
    {
        public IResultElementFactory()
        {
        }

        public IResultElement Create(
            FhirDateTime day,
            INullableValue<int> scenario,
            decimal value)
        {
            IResultElement resultElement = default;

            try
            {
                resultElement = new IResultElement(
                    day: day,
                    scenario: scenario,
                    value: value);
            }
            finally
            {
            }

            return resultElement;
        }
    }
}