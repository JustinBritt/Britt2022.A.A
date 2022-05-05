namespace Britt2022.A.A.Variables.InterfacesFactories
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public interface Id2MinusFactory
    {
        Id2Minus Create(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω);
    }
}