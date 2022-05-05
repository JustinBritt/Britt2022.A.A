namespace Britt2022.A.A.ObjectiveFunctions.Classes
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.VariableElements.Structs;

    public sealed class Goal3 : IGoal3
    {
        public Goal3()
        {
        }

        public unsafe double GetValue(
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<iωCrossJoinElement> iω,
            double w3,
            ReadOnlySpan<ΡParameterElement> Ρ,
            ReadOnlySpan<IMaxVariableElement> IMax)
        {
            double sum = 0;

            fixed (ΡParameterElement * ΡPtr = Ρ)
            fixed (IMaxVariableElement * IMaxPtr = IMax)
            {
                for (int w = 1; w < ω.Length; w = w + 1)
                {
                    sum +=
                        w3
                        *
                        (*(ΡPtr + ω[w].Value)).Value
                        *
                        (*(IMaxPtr + ω[w].Value)).Value;
                }
            }

            return sum;
        }
    }
}