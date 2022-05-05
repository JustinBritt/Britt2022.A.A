namespace Britt2022.A.A.Results.Factories.SurgeonScenarioDeviations
{
    using Britt2022.A.A.Results.Classes.SurgeonScenarioDeviations;
    using Britt2022.A.A.Results.Interfaces.SurgeonScenarioDeviations;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonScenarioDeviations;

    public sealed class d1PlusFactory : Id1PlusFactory
    {
        public d1PlusFactory()
        {
        }

        public Id1Plus Create()
        {
            Id1Plus result = null;

            try
            {
                result = new d1Plus();
            }
            finally
            {
            }

            return result;
        }
    }
}