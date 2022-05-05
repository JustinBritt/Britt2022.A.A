namespace Britt2022.A.A.ILS.Factories
{
    using Britt2022.A.A.ILS.Classes;
    using Britt2022.A.A.ILS.Interfaces;
    using Britt2022.A.A.ILS.InterfacesFactories;

    internal sealed class IteratedLocalSearchFactory : IIteratedLocalSearchFactory
    {
        public IteratedLocalSearchFactory()
        {
        }

        public IIteratedLocalSearch Create()
        {
            IIteratedLocalSearch iteratedLocalSearch = null;

            try
            {
                iteratedLocalSearch = new IteratedLocalSearch();
            }
            finally
            {
            }

            return iteratedLocalSearch;
        }
    }
}