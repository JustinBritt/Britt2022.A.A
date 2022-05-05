namespace Britt2022.A.A.Variables.InterfacesFactories
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public interface IIFactory
    {
        II Create(
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω);
    }
}