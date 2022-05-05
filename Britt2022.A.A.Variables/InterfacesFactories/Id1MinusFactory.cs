namespace Britt2022.A.A.Variables.InterfacesFactories
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public interface Id1MinusFactory
    {
        Id1Minus Create(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω);
    }
}