namespace Britt2022.A.A.Constraints.InterfacesFactories
{
    using System;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.IndexElements.Structs;

    public interface IConstraints5UFactory
    {
        IConstraints5U Create(
            ReadOnlySpan<iIndexElement> i);
    }
}