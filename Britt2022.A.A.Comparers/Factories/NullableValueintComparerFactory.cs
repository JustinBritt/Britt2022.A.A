namespace Britt2022.A.A.Comparers.Factories
{
    using Britt2022.A.A.Comparers.Classes;
    using Britt2022.A.A.Comparers.Interfaces;
    using Britt2022.A.A.Comparers.InterfacesFactories;

    internal sealed class NullableValueintComparerFactory : INullableValueintComparerFactory
    {
        public NullableValueintComparerFactory()
        {
        }

        public INullableValueintComparer Create()
        {
            INullableValueintComparer instance = null;

            try
            {
                instance = new NullableValueintComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}