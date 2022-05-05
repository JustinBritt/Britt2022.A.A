namespace Britt2022.A.A.ObjectiveFunctions.Classes
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.VariableElements.Structs;

    public sealed class Goal2 : IGoal2
    {
        public Goal2()
        {
        }

        public unsafe double GetValue(
            double v,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkωCrossJoinElement> ijkω,
            double w2,
            ReadOnlySpan<ΡParameterElement> Ρ,
            ReadOnlySpan<d2MinusVariableElement> d2Minus,
            ReadOnlySpan<xVariableElement> x)
        {
            double sum = 0;

            fixed (ΡParameterElement * ΡPtr = Ρ)
            fixed (d2MinusVariableElement * d2MinusPtr = d2Minus)
            {
                for (int w = 1; w < ijkω.Length; w = w + 1)
                {
                    sum +=
                        w2
                        *
                        (*(ΡPtr + ijkω[w].ωIndexElement)).Value
                        *
                        (*(d2MinusPtr + ijkω[w].ijkωOI)).Value;
                }
            }

            return sum;
        }
    }
}