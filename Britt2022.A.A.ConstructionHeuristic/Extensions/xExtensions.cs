namespace Britt2022.A.A.ConstructionHeuristic.Extensions
{
    using System;
    
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;

    public static class xExtensions
    {
        public unsafe static void AssignAt(
            this Span<xVariableElement> x,
            iIndexElement iIndexElement,
            jIndexElement jIndexElement,
            kIndexElement kIndexElement,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k)
        {
            fixed (xVariableElement * xPtr = x)
            {
                (*(xPtr + iIndexElement.Value + (jIndexElement.Value * (i.Length - 1)) + (kIndexElement.Value * (i.Length - 1) * (j.Length - 1)))).Value = 1;
            }
        }

        public unsafe static xVariableElement GetElementAt(
            this Span<xVariableElement> x,
            iIndexElement iIndexElement,
            jIndexElement jIndexElement,
            kIndexElement kIndexElement,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k)
        {
            fixed (xVariableElement* xPtr = x)
            {
                return *(xPtr + iIndexElement.Value + (jIndexElement.Value * (i.Length - 1)) + (kIndexElement.Value * (i.Length - 1) * (j.Length - 1)));
            }
        }

        public unsafe static int Sum(
            this Span<xVariableElement> x,
            iIndexElement iIndexElement,
            ReadOnlySpan<ijkCrossJoinElement> ijk)
        {
            int sum = 0;

            fixed (xVariableElement * xPtr = x)
            {
                for (int w = 0; w < ijk.Length; w = w + 1)
                {
                    if (ijk[w].iIndexElement == iIndexElement.Value)
                    {
                        sum += x[ijk[w].ijkOI].Value;
                    }
                }
            }

            return sum;
        }

        public unsafe static int Sum(
            this Span<xVariableElement> x,
            jIndexElement jIndexElement,
            kIndexElement kIndexElement,
            ReadOnlySpan<ijkCrossJoinElement> ijk)
        {
            int sum = 0;

            fixed (xVariableElement * xPtr = x)
            {
                for (int w = 0; w < ijk.Length; w = w + 1)
                {
                    if (ijk[w].jIndexElement == jIndexElement.Value && ijk[w].kIndexElement == kIndexElement.Value)
                    {
                        sum += x[ijk[w].ijkOI].Value;
                    }
                }
            }

            return sum;
        }

        public unsafe static int Sum(
            this Span<xVariableElement> x,
            iIndexElement iIndexElement,
            kIndexElement kIndexElement,
            ReadOnlySpan<ijkCrossJoinElement> ijk)
        {
            int sum = 0;

            fixed (xVariableElement * xPtr = x)
            {
                for (int w = 0; w < ijk.Length; w = w + 1)
                {
                    if (ijk[w].iIndexElement == iIndexElement.Value && ijk[w].kIndexElement == kIndexElement.Value)
                    {
                        sum += x[ijk[w].ijkOI].Value;
                    }
                }
            }

            return sum;
        }

        public unsafe static int Sum(
            this Span<xVariableElement> x,
            B1ParameterElement B1ParameterElement,
            F2ParameterElement F2ParameterElement,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ijkCrossJoinElement> ijk)
        {
            int sum = 0;

            fixed (xVariableElement * xPtr = x)
            {
                for (int w = B1ParameterElement.Value; w <= F2ParameterElement.Value; w = w + 1)
                {
                    sum += x.Sum(i[w], ijk);
                }
            }

            return sum;
        }
    }
}