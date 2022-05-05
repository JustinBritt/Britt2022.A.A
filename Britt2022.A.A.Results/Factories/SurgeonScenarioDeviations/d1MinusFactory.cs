namespace Britt2022.A.A.Results.Factories.SurgeonScenarioDeviations
{
    using Britt2022.A.A.Results.Classes.SurgeonScenarioDeviations;
    using Britt2022.A.A.Results.Interfaces.SurgeonScenarioDeviations;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonScenarioDeviations;

    public sealed class d1MinusFactory : Id1MinusFactory
    {
        public d1MinusFactory()
        {
        }

        public Id1Minus Create()
        {
            Id1Minus result = null;

            try
            {
                result = new d1Minus();
            }
            finally
            {
            }

            return result;
        }
    }
}