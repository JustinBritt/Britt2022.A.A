namespace Britt2022.A.A.ObjectiveFunctions.Classes
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.VariableElements.Structs;

    public sealed class Goal4 : IGoal4
    {
        public Goal4()
        {
        }

        public unsafe double GetValue(
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<iωCrossJoinElement> iω,
            double w4,
            ReadOnlySpan<ΡParameterElement> Ρ,
            ReadOnlySpan<IMaxVariableElement> IMax,
            ReadOnlySpan<IMinVariableElement> IMin)
        {
            double sum = 0;

            fixed (ΡParameterElement * ΡPtr = Ρ)
            fixed (IMaxVariableElement * IMaxPtr = IMax)
            fixed (IMinVariableElement * IMinPtr = IMin)
            {
                for (int w = 1; w < ω.Length; w = w + 1)
                {
                    sum +=
                        w4
                        *
                        (*(ΡPtr + ω[w].Value)).Value
                        *
                        ((*(IMaxPtr + ω[w].Value)).Value
                        -
                        (*(IMinPtr + ω[w].Value)).Value);
                }
            }

            return sum;
        }
    }
}