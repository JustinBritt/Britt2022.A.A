namespace Britt2022.A.A.Constraints.Factories
{
    using System;

    using Britt2022.A.A.Constraints.Classes;
    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class Constraints3Factory : IConstraints3Factory
    {
        public Constraints3Factory()
        {
        }

        public IConstraints3 Create(
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k)
        {
            IConstraints3 constraints = null;

            try
            {
                constraints = new Constraints3(
                    j,
                    k);
            }
            finally
            {
            }

            return constraints;
        }
    }
}