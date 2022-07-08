namespace Britt2022.A.A.ObjectiveFunctions.Interfaces
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.VariableElements.Structs;

    public interface IGoal4
    {
        double GetValue(
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<iωCrossJoinElement> iω,
            double w4,
            ReadOnlySpan<ΡParameterElement> Ρ,
            Span<IMaxVariableElement> IMax,
            Span<IMinVariableElement> IMin);
    }
}