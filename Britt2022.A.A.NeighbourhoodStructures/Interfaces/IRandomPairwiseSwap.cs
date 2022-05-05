namespace Britt2022.A.A.NeighbourhoodStructures.Interfaces
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;

    public interface IRandomPairwiseSwap
    {
        bool SwapMade { get; set; }

        void Swap(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            Span<xVariableElement> x);

        void UndoSwap(
            Span<xVariableElement> x);
    }
}