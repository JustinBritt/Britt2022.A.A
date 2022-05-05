namespace Britt2022.A.A.ConstructionHeuristic.Classes
{
    using System;
    using System.Linq;

    using Britt2022.A.A.ConstructionHeuristic.Extensions;
    using Britt2022.A.A.ConstructionHeuristic.Interfaces;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;

    public sealed class ConstructionHeuristic : IConstructionHeuristic
    {
        public unsafe void GenerateInitialFeasibleSchedule(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<BParameterElement> B,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            ReadOnlySpan<HParameterElement> H,
            ReadOnlySpan<LParameterElement> L,
            ReadOnlySpan<ΠParameterElement> Π,
            ReadOnlySpan<ΩParameterElement> Ω,
            Span<xVariableElement> x)
        {
            Random uniformIntDistributionjIndexElement = new Random();

            Random uniformIntDistributionkIndexElement = new Random();

            for (int iIndexElement = 1; iIndexElement < i.Length; iIndexElement = iIndexElement + 1)
            {
                this.SatisfyConstraints5ForSurgeon(
                    i[iIndexElement],
                    uniformIntDistributionjIndexElement,
                    uniformIntDistributionkIndexElement,
                    i,
                    j,
                    k,
                    r,
                    ijk,
                    B,
                    B1,
                    F2,
                    H,
                    L,
                    Π,
                    Ω,
                    x);
            }

            int[] numberBlocksArray = new int[r.Length];

            for (int rIndexElement = 1; rIndexElement < r.Length; rIndexElement = rIndexElement + 1)
            {
                numberBlocksArray[rIndexElement] = B[rIndexElement].Value - x.Sum(B1[rIndexElement], F2[rIndexElement], i, ijk);
            }

            Span<int> numberBlocks = new Span<int>(
                numberBlocksArray);

            for (int rIndexElement = 1; rIndexElement < r.Length; rIndexElement = rIndexElement + 1)
            {
                this.SatisfyConstraints9ForSurgicalSpecialty(
                    uniformIntDistributionjIndexElement,
                    uniformIntDistributionkIndexElement,
                    r[rIndexElement],
                    i,
                    j,
                    k,
                    ijk,
                    B,
                    B1,
                    F2,
                    numberBlocks,
                    H,
                    L,
                    Π,
                    Ω,
                    x);
            }
        }

        public unsafe void SatisfyConstraints5ForSurgeon(
            iIndexElement iIndexElement,
            Random uniformIntDistributionjIndexElement,
            Random uniformIntDistributionkIndexElement,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<BParameterElement> B,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            ReadOnlySpan<HParameterElement> H,
            ReadOnlySpan<LParameterElement> L,
            ReadOnlySpan<ΠParameterElement> Π,
            ReadOnlySpan<ΩParameterElement> Ω,
            Span<xVariableElement> x)
        {
            fixed (BParameterElement * BPtr = B)
            fixed (LParameterElement * LPtr = L)
            fixed (ΠParameterElement * ΠPtr = Π)
            fixed (ΩParameterElement * ΩPtr = Ω)
            fixed (xVariableElement * xPtr = x)
            {
                while (x.Sum(iIndexElement, ijk) < (*(LPtr + iIndexElement.Value)).Value)
                {
                    jIndexElement jIndexElement = j[uniformIntDistributionjIndexElement.Next(1, j.Length - 1)];

                    kIndexElement kIndexElement = k[uniformIntDistributionkIndexElement.Next(1, k.Length - 1)];

                    if (x.GetElementAt(iIndexElement, jIndexElement, kIndexElement, i, j, k).Value == 0
                        &&
                        Π.GetElementAt(iIndexElement, jIndexElement, i).Value == 0
                        &&
                        Ω.GetElementAt(iIndexElement, kIndexElement, i).Value == 0
                        &&
                        x.Sum(jIndexElement, kIndexElement, ijk) == 0
                        &&
                        x.Sum(iIndexElement, kIndexElement, ijk) == 0)
                    {
                        x.AssignAt(
                            iIndexElement,
                            jIndexElement,
                            kIndexElement,
                            i,
                            j,
                            k);
                    }
                }
            }
        }

        public unsafe void SatisfyConstraints9ForSurgicalSpecialty(
            Random uniformIntDistributionjIndexElement,
            Random uniformIntDistributionkIndexElement,
            rIndexElement rIndexElement,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<BParameterElement> B,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            Span<int> numberBlocks,
            ReadOnlySpan<HParameterElement> H,
            ReadOnlySpan<LParameterElement> L,
            ReadOnlySpan<ΠParameterElement> Π,
            ReadOnlySpan<ΩParameterElement> Ω,
            Span<xVariableElement> x)
        {
            Random uniformIntDistributioniIndexElement = new Random();

            int numberBlocksAvailablesurgicalSpecialty = numberBlocks[rIndexElement.Value];

            while (numberBlocksAvailablesurgicalSpecialty > 0)
            {
                iIndexElement iIndexElement = i[uniformIntDistributioniIndexElement.Next(B1[rIndexElement.Value].Value, F2[rIndexElement.Value].Value + 1)];

                jIndexElement jIndexElement = j[uniformIntDistributionjIndexElement.Next(1, j.Length - 1)];

                kIndexElement kIndexElement = k[uniformIntDistributionkIndexElement.Next(1, k.Length - 1)];

                if (x.GetElementAt(iIndexElement, jIndexElement, kIndexElement, i, j, k).Value == 0
                    &&
                    Π.GetElementAt(iIndexElement, jIndexElement, i).Value == 0
                    &&
                    Ω.GetElementAt(iIndexElement, kIndexElement, i).Value == 0
                    &&
                    x.Sum(jIndexElement, kIndexElement, ijk) == 0
                    &&
                    x.Sum(iIndexElement, kIndexElement, ijk) == 0
                    &&
                    x.Sum(iIndexElement, ijk) < H[iIndexElement.Value].Value)
                {
                    x.AssignAt(
                        iIndexElement,
                        jIndexElement,
                        kIndexElement,
                        i,
                        j,
                        k);

                    numberBlocksAvailablesurgicalSpecialty = numberBlocksAvailablesurgicalSpecialty - 1;
                }
            }
        }
    }
}