namespace Britt2022.A.A.ResultElements.Factories.ScenarioRecoveryWardCensuses
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.InterfacesFactories.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;

    internal sealed class IMinResultElementFactory : IIMinResultElementFactory
    {
        public IMinResultElementFactory()
        {
        }

        public IMinResultElement Create(
            PositiveInt scenario,
            decimal value)
        {
            IMinResultElement resultElement = default;

            try
            {
                resultElement = new IMinResultElement(
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