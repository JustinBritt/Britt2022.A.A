namespace Britt2022.A.A.Results.Factories.ScenarioRecoveryWardCensuses
{
    using Britt2022.A.A.Results.Classes.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.Interfaces.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.InterfacesFactories.ScenarioRecoveryWardCensuses;

    public sealed class IMinFactory : IIMinFactory
    {
        public IMinFactory()
        {
        }

        public IIMin Create()
        {
            IIMin result = null;

            try
            {
                result = new IMin();
            }
            finally
            {
            }

            return result;
        }
    }
}