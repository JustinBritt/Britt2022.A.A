namespace Britt2022.A.A.Constraints.Interfaces
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;

    public interface IConstraints9 : IDisposable
    {
        bool IsFeasible(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            ReadOnlySpan<BParameterElement> B,
            Span<xVariableElement> x);
    }
}