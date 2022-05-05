namespace Britt2022.A.A.Constraints.Interfaces
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.VariableElements.Structs;

    public interface IConstraints1
    {
        bool IsFeasible(
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<ΠParameterElement> Π,
            Span<xVariableElement> x);
    }
}