namespace Britt2022.A.A.GS.Factories
{
    using Britt2022.A.A.GS.Classes;
    using Britt2022.A.A.GS.Interfaces;
    using Britt2022.A.A.GS.InterfacesFactories;

    internal sealed class ParametersFactory : IParametersFactory
    {
        public ParametersFactory()
        {
        }

        public IParameters Create(
            long maximumNumberTicks)
        {
            IParameters parameters = null;

            try
            {
                parameters = new Parameters(
                    maximumNumberTicks: maximumNumberTicks);
            }
            finally
            {
            }

            return parameters;
        }
    }
}