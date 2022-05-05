﻿namespace Britt2022.A.A.Constraints.Interfaces
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;

    public interface IConstraints : IDisposable
    {
        bool IsFeasible(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<ikCrossJoinElement> ik,
            ReadOnlySpan<jkCrossJoinElement> jk,
            ReadOnlySpan<BParameterElement> B,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            ReadOnlySpan<HParameterElement> H,
            ReadOnlySpan<LParameterElement> L,
            ReadOnlySpan<ΠParameterElement> Π,
            ReadOnlySpan<ΩParameterElement> Ω,
            Span<xVariableElement> x);
    }
}