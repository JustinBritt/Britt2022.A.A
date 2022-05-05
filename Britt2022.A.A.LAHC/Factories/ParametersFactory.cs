namespace Britt2022.A.A.LAHC.Factories
{
    using Britt2022.A.A.LAHC.Classes;
    using Britt2022.A.A.LAHC.Interfaces;
    using Britt2022.A.A.LAHC.InterfacesFactories;

    internal sealed class ParametersFactory : IParametersFactory
    {
        public ParametersFactory()
        {
        }

        public IParameters Create(
            int fitnessArrayLength)
        {
            IParameters parameters = null;

            try
            {
                parameters = new Parameters(
                    fitnessArrayLength: fitnessArrayLength);
            }
            finally
            {
            }

            return parameters;
        }

        public IParameters Create(
            ISolverConfiguration solverConfiguration)
        {
            IParameters parameters = null;

            try
            {
                parameters = new Parameters(
                    fitnessArrayLength: solverConfiguration.FitnessArrayLength);
            }
            finally
            {
            }

            return parameters;
        }
    }
}