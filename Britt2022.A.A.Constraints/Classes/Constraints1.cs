namespace Britt2022.A.A.Constraints.Classes
{
    using System;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class Constraints1 : IConstraints1
    {
        public Constraints1()
        {
        }

        public unsafe bool IsFeasible(
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<ΠParameterElement> Π,
            Span<xVariableElement> x)
        {
            bool feasible = true;

            fixed (ijkCrossJoinElement * ijkPtr = ijk)
            fixed (ΠParameterElement * ΠPtr = Π)
            fixed (xVariableElement * xPtr = x)
            {
                for (int w = 1; w < ijk.Length; w = w + 1)
                {
                    if ((*(xPtr + (*(ijkPtr + w)).ijkOI)).Value == 1
                        &&
                        (*(ΠPtr + (*(ijkPtr + w)).ijOI)).Value == 1)
                    {
                        feasible = false;

                        return feasible;
                    }
                }
            }

            return true;
        }
    }
}