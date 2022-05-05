namespace Britt2022.A.A.Constraints.Factories
{
    using System;

    using Britt2022.A.A.Constraints.Classes;
    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class Constraints5LFactory : IConstraints5LFactory
    {
        public Constraints5LFactory()
        {
        }

        public IConstraints5L Create(
            ReadOnlySpan<iIndexElement> i)
        {
            IConstraints5L constraints = null;

            try
            {
                constraints = new Constraints5L(
                    i);
            }
            finally
            {
            }

            return constraints;
        }
    }
}