namespace Britt2022.A.A.Results.Factories.ScenarioRecoveryWardCensuses
{
    using Britt2022.A.A.Results.Classes.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.Interfaces.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.InterfacesFactories.ScenarioRecoveryWardCensuses;

    public sealed class IMaxFactory : IIMaxFactory
    {
        public IMaxFactory()
        {
        }

        public IIMax Create()
        {
            IIMax result = null;

            try
            {
                result = new IMax();
            }
            finally
            {
            }

            return result;
        }
    }
}