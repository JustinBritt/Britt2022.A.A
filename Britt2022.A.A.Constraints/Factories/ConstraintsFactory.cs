namespace Britt2022.A.A.Constraints.Factories
{
    using System;

    using Britt2022.A.A.Constraints.Classes;
    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class ConstraintsFactory : IConstraintsFactory
    {
        public ConstraintsFactory()
        {
        }

        public IConstraints Create(
            IConstraints1Factory constraints1Factory,
            IConstraints2Factory constraints2Factory,
            IConstraints3Factory constraints3Factory,
            IConstraints4Factory constraints4Factory,
            IConstraints5LFactory constraints5LFactory,
            IConstraints5UFactory constraints5UFactory,
            IConstraints9Factory constraints9Factory,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r)
        {
            IConstraints constraints = null;

            try
            {
                constraints = new Constraints(
                    constraints1Factory,
                    constraints2Factory,
                    constraints3Factory,
                    constraints4Factory,
                    constraints5LFactory,
                    constraints5UFactory,
                    constraints9Factory,
                    i,
                    j,
                    k,
                    r);
            }
            finally
            {
            }

            return constraints;
        }
    }
}