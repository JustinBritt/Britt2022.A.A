namespace Britt2022.A.A.ObjectiveFunctions.Interfaces
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.VariableElements.Structs;

    public interface IGoal2
    {
        double GetValue(
            double v,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkωCrossJoinElement> ijkω,
            double w2,
            ReadOnlySpan<ΡParameterElement> Ρ,
            ReadOnlySpan<d2MinusVariableElement> d2Minus,
            ReadOnlySpan<xVariableElement> x);
    }
}