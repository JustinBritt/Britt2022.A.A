namespace Britt2022.A.A.Solutions.Factories
{
    using Britt2022.A.A.Solutions.Classes;
    using Britt2022.A.A.Solutions.Interfaces;
    using Britt2022.A.A.Solutions.InterfacesFactories;

    public sealed class WGPMSolutionFactory : IWGPMSolutionFactory
    {
        public WGPMSolutionFactory()
        {
        }

        public IWGPMSolution Create()
        {
            IWGPMSolution solution = null;

            try
            {
                solution = new WGPMSolution();
            }
            finally
            {
            }

            return solution;
        }
    }
}