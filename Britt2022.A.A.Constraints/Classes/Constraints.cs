namespace Britt2022.A.A.Constraints.Classes
{
    using System;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;

    public sealed class Constraints : IConstraints
    {
        public Constraints(
            IConstraints1Factory constraints1Factory,
            IConstraints2Factory constraints2Factory,
            IConstraints3Factory constraints3Factory,
            IConstraints4Factory constraints4Factory,
            IConstraints5LFactory constraints5LFactory,
            IConstraints5UFactory constraints5UFactory,
            IConstraints9Factory constraints9Factory,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r)
        {
            this.Constraints1 = constraints1Factory.Create();

            this.Constraints2 = constraints2Factory.Create();

            this.Constraints3 = constraints3Factory.Create(
                j,
                k);

            this.Constraints4 = constraints4Factory.Create(
                i,
                k);

            this.Constraints5L = constraints5LFactory.Create(
                i);

            this.Constraints5U = constraints5UFactory.Create(
                i);

            this.Constraints9 = constraints9Factory.Create(
                r);
        }

        private IConstraints1 Constraints1 { get; }

        private IConstraints2 Constraints2 { get; }

        private IConstraints3 Constraints3 { get; }

        private IConstraints4 Constraints4 { get; }

        private IConstraints5L Constraints5L { get; }

        private IConstraints5U Constraints5U { get; }

        private IConstraints9 Constraints9 { get; }

        public bool IsFeasible(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<ikCrossJoinElement> ik,
            ReadOnlySpan<jkCrossJoinElement> jk,
            ReadOnlySpan<BParameterElement> B,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            ReadOnlySpan<HParameterElement> H,
            ReadOnlySpan<LParameterElement> L,
            ReadOnlySpan<ΠParameterElement> Π,
            ReadOnlySpan<ΩParameterElement> Ω,
            Span<xVariableElement> x)
        {
            bool feasible = true;

            feasible = this.Constraints1.IsFeasible(ijk, Π, x)
                       && this.Constraints2.IsFeasible(ijk, Ω, x)
                       && this.Constraints3.IsFeasible(i, j, k, ijk, jk, x)
                       && this.Constraints4.IsFeasible(i, j, k, ijk, ik, x)
                       && this.Constraints5L.IsFeasible(i, j, k, ijk, L, x)
                       && this.Constraints5U.IsFeasible(i, j, k, ijk, H, x)
                       && this.Constraints9.IsFeasible(i, j, k, r, ijk, B1, F2, B, x);

            return feasible;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.Constraints3.Dispose();

                this.Constraints4.Dispose();

                this.Constraints5L.Dispose();

                this.Constraints5U.Dispose();

                this.Constraints9.Dispose();
            }
        }
    }
}