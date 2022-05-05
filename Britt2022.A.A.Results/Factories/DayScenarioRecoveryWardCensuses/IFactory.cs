namespace Britt2022.A.A.Results.Factories.DayScenarioRecoveryWardCensuses
{
    using Britt2022.A.A.Results.Classes.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.Interfaces.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.InterfacesFactories.DayScenarioRecoveryWardCensuses;

    public sealed class IFactory : IIFactory
    {
        public IFactory()
        {
        }

        public II Create()
        {
            II result = null;

            try
            {
                result = new I();
            }
            finally
            {
            }

            return result;
        }
    }
}