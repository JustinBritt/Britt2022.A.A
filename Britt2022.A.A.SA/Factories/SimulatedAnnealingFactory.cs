namespace Britt2022.A.A.SA.Factories
{
    using Britt2022.A.A.SA.Classes;
    using Britt2022.A.A.SA.Interfaces;
    using Britt2022.A.A.SA.InterfacesFactories;

    internal sealed class SimulatedAnnealingFactory : ISimulatedAnnealingFactory
    {
        public SimulatedAnnealingFactory()
        {
        }

        public ISimulatedAnnealing Create()
        {
            ISimulatedAnnealing simulatedAnnealing = null;

            try
            {
                simulatedAnnealing = new SimulatedAnnealing();
            }
            finally
            {
            }

            return simulatedAnnealing;
        }
    }
}