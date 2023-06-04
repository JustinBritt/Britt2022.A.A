namespace Britt2022.A.A.ResultElements.Factories.SurgeonScenarioDeviations
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;

    internal sealed class d1MinusResultElementFactory : Id1MinusResultElementFactory
    {
        public d1MinusResultElementFactory()
        {
        }

        public d1MinusResultElement Create(
            Organization surgeon,
            INullableValue<int> scenario,
            int value)
        {
            d1MinusResultElement resultElement = default;

            try
            {
                resultElement = new d1MinusResultElement(
                    surgeon: surgeon,
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