namespace Britt2022.A.A.ILS.Factories
{
    using Britt2022.A.A.ILS.Classes;
    using Britt2022.A.A.ILS.Interfaces;
    using Britt2022.A.A.ILS.InterfacesFactories;

    internal sealed class ParametersFactory : IParametersFactory
    {
        public ParametersFactory()
        {
        }

        public IParameters Create(
            int numberIterations,
            int numberPerturbations)
        {
            IParameters parameters = null;

            try
            {
                parameters = new Parameters(
                    numberIterations: numberIterations,
                    numberPerturbations: numberPerturbations);
            }
            finally
            {
            }

            return parameters;
        }
    }
}