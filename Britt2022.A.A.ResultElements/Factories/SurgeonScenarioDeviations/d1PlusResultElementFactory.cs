namespace Britt2022.A.A.ResultElements.Factories.SurgeonScenarioDeviations
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;

    internal sealed class d1PlusResultElementFactory : Id1PlusResultElementFactory
    {
        public d1PlusResultElementFactory()
        {
        }

        public d1PlusResultElement Create()
        {
            d1PlusResultElement resultElement = default;

            try
            {
                resultElement = new d1PlusResultElement();
            }
            finally
            {
            }

            return resultElement;
        }
    }
}