namespace Britt2022.A.A.Constraints.Interfaces
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.VariableElements.Structs;

    public interface IConstraints3 : IDisposable
    {
        bool IsFeasible(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<jkCrossJoinElement> jk,
            Span<xVariableElement> x);
    }
}