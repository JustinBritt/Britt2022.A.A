namespace Britt2022.A.A.ResultElements.Factories.ScenarioRecoveryWardCensuses
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.InterfacesFactories.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;

    internal sealed class IMaxResultElementFactory : IIMaxResultElementFactory
    {
        public IMaxResultElementFactory()
        {
        }

        public IMaxResultElement Create()
        {
            IMaxResultElement resultElement = default;

            try
            {
                resultElement = new IMaxResultElement();
            }
            finally
            {
            }

            return resultElement;
        }
    }
}