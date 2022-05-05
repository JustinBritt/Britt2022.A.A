namespace Britt2022.A.A.Constraints.Factories
{
    using System;

    using Britt2022.A.A.Constraints.Classes;
    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class Constraints9Factory : IConstraints9Factory
    {
        public Constraints9Factory()
        {
        }

        public IConstraints9 Create(
            ReadOnlySpan<rIndexElement> r)
        {
            IConstraints9 constraints = null;

            try
            {
                constraints = new Constraints9(
                    r);
            }
            finally
            {
            }

            return constraints;
        }
    }
}