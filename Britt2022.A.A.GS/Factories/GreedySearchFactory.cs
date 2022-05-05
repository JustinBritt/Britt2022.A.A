namespace Britt2022.A.A.GS.Factories
{
    using Britt2022.A.A.GS.Classes;
    using Britt2022.A.A.GS.Interfaces;
    using Britt2022.A.A.GS.InterfacesFactories;

    internal sealed class GreedySearchFactory : IGreedySearchFactory
    {
        public GreedySearchFactory()
        {
        }

        public IGreedySearch Create()
        {
            IGreedySearch greedySearch = null;

            try
            {
                greedySearch = new GreedySearch();
            }
            finally
            {
            }

            return greedySearch;
        }
    }
}