namespace Britt2022.A.A.Constraints.Factories
{
    using System;

    using Britt2022.A.A.Constraints.Classes;
    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class Constraints5UFactory : IConstraints5UFactory
    {
        public Constraints5UFactory()
        {
        }

        public IConstraints5U Create(
            ReadOnlySpan<iIndexElement> i)
        {
            IConstraints5U constraints = null;

            try
            {
                constraints = new Constraints5U(
                    i);
            }
            finally
            {
            }

            return constraints;
        }
    }
}