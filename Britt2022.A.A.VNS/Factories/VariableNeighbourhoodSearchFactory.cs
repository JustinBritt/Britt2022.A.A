namespace Britt2022.A.A.VNS.Factories
{
    using Britt2022.A.A.VNS.Classes;
    using Britt2022.A.A.VNS.Interfaces;
    using Britt2022.A.A.VNS.InterfacesFactories;

    internal sealed class VariableNeighbourhoodSearchFactory : IVariableNeighbourhoodSearchFactory
    {
        public VariableNeighbourhoodSearchFactory()
        {
        }

        public IVariableNeighbourhoodSearch Create()
        {
            IVariableNeighbourhoodSearch variableNeighbourhoodSearch = null;

            try
            {
                variableNeighbourhoodSearch = new VariableNeighbourhoodSearch();
            }
            finally
            {
            }

            return variableNeighbourhoodSearch;
        }
    }
}