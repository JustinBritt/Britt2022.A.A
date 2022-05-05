namespace Britt2022.A.A.ConstructionHeuristic.Extensions
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;

    public static class ΠExtensions
    {
        public unsafe static ΠParameterElement GetElementAt(
            this ReadOnlySpan<ΠParameterElement> Π,
            iIndexElement iIndexElement,
            jIndexElement jIndexElement,
            ReadOnlySpan<iIndexElement> i)
        {
            fixed (ΠParameterElement * ΠPtr = Π)
            {
                return *(ΠPtr + iIndexElement.Value + (jIndexElement.Value * (i.Length - 1)));
            }
        }
    }
}