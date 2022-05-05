namespace Britt2022.A.A.Constraints.Factories
{
    using System;

    using Britt2022.A.A.Constraints.Classes;
    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class Constraints4Factory : IConstraints4Factory
    {
        public Constraints4Factory()
        {
        }

        public IConstraints4 Create(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<kIndexElement> k)
        {
            IConstraints4 constraints = null;

            try
            {
                constraints = new Constraints4(
                    i,
                    k);
            }
            finally
            {
            }

            return constraints;
        }
    }
}