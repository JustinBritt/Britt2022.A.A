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

        public d1MinusResultElement Create()
        {
            d1MinusResultElement resultElement = default;

            try
            {
                resultElement = new d1MinusResultElement();
            }
            finally
            {
            }

            return resultElement;
        }
    }
}