namespace Britt2022.A.A.Constraints.Interfaces
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.VariableElements.Structs;

    public interface IConstraints2
    {
        bool IsFeasible(
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<ΩParameterElement> Ω,
            Span<xVariableElement> x);
    }
}