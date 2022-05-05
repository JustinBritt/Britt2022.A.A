namespace Britt2022.A.A.Constraints.InterfacesFactories
{
    using System;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.IndexElements.Structs;

    public interface IConstraintsFactory
    {
        IConstraints Create(
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
            ReadOnlySpan<rIndexElement> r);
    }
}