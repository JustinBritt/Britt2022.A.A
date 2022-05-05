namespace Britt2022.A.A.ObjectiveFunctions.Interfaces
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.VariableElements.Structs;

    public interface IGoal1
    {
        double GetValue(
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<iωCrossJoinElement> iω,
            double w1,
            ReadOnlySpan<ΡParameterElement> Ρ,
            ReadOnlySpan<d1MinusVariableElement> d1Minus,
            ReadOnlySpan<xVariableElement> x);
    }
}