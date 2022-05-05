namespace Britt2022.A.A.Constraints.InterfacesFactories
{
    using System;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.IndexElements.Structs;

    public interface IConstraints9Factory
    {
        IConstraints9 Create(
            ReadOnlySpan<rIndexElement> r);
    }
}