namespace Britt2022.A.A.VNS.Factories
{
    using Britt2022.A.A.VNS.Classes;
    using Britt2022.A.A.VNS.Interfaces;
    using Britt2022.A.A.VNS.InterfacesFactories;

    internal sealed class VariableNeighbourhoodSearchBridgeFactory : IVariableNeighbourhoodSearchBridgeFactory
    {
        public VariableNeighbourhoodSearchBridgeFactory()
        {
        }

        public IVariableNeighbourhoodSearchBridge Create()
        {
            IVariableNeighbourhoodSearchBridge variableNeighbourhoodSearchBridge = null;

            try
            {
                variableNeighbourhoodSearchBridge = new VariableNeighbourhoodSearchBridge();
            }
            finally
            {
            }

            return variableNeighbourhoodSearchBridge;
        }
    }
}