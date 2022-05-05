namespace Britt2022.A.A.ObjectiveFunctions.Classes
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.VariableElements.Structs;

    public sealed class Goal1 : IGoal1
    {
        public Goal1()
        {
        }

        public unsafe double GetValue(
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<iωCrossJoinElement> iω,
            double w1,
            ReadOnlySpan<ΡParameterElement> Ρ,
            ReadOnlySpan<d1MinusVariableElement> d1Minus,
            ReadOnlySpan<xVariableElement> x)
        {
            double sum = 0;

            fixed (ΡParameterElement * ΡPtr = Ρ)
            fixed (d1MinusVariableElement * d1MinusPtr = d1Minus)
            {
                for (int w = 1; w < iω.Length; w = w + 1)
                {
                    sum +=
                        w1
                        *
                        (*(ΡPtr + iω[w].ωIndexElement)).Value
                        *
                        (*(d1MinusPtr + iω[w].iωOI)).Value;
                }
            }

            return sum;
        }
    }
}