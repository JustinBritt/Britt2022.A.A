namespace Britt2022.A.A.ConstructionHeuristic.Extensions
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;

    public static class ΩExtensions
    {
        public unsafe static ΩParameterElement GetElementAt(
            this ReadOnlySpan<ΩParameterElement> Ω,
            iIndexElement iIndexElement,
            kIndexElement kIndexElement,
            ReadOnlySpan<iIndexElement> i)
        {
            fixed (ΩParameterElement * ΩPtr = Ω)
            {
                return *(ΩPtr + iIndexElement.Value + (kIndexElement.Value * (i.Length - 1)));
            }
        }
    }
}