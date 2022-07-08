namespace Britt2022.A.A.ObjectiveFunctions.Classes
{
    using System;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public sealed class ObjectiveFunction : IObjectiveFunction
    {
        public ObjectiveFunction()
        {
        }

        public double GetValue(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<lIndexElement> l,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<ijkωCrossJoinElement> ijkω,
            ReadOnlySpan<ilωCrossJoinElement> ilω,
            ReadOnlySpan<iωCrossJoinElement> iω,
            ReadOnlySpan<kωCrossJoinElement> kω,
            ReadOnlySpan<AParameterElement> A,
            ReadOnlySpan<NParameterElement> N,
            ReadOnlySpan<niωParameterElement> niω,
            double v,
            double w1,
            double w2,
            double w3,
            double w4,
            ReadOnlySpan<ΡParameterElement> Ρ,
            ReadOnlySpan<ΦParameterElement> Φ,
            Id1Minus d1Minus,
            Id2Minus d2Minus,
            II I,
            IIMax IMax,
            IIMin IMin,
            Span<xVariableElement> x,
            IGoal1 goal1,
            IGoal2 goal2,
            IGoal3 goal3,
            IGoal4 goal4)
        {
            Span<IVariableElement> ISpan = I.GetValue(
                i,
                j,
                k,
                l,
                ω,
                ilω,
                Φ,
                x);

            Span<IMaxVariableElement> IMaxSpan = IMax.GetValue(
                i,
                j,
                k,
                ω,
                kω,
                ISpan);

            Span<IMinVariableElement> IMinSpan = IMin.GetValue(
                i,
                j,
                k,
                ω,
                kω,
                ISpan);

            return
                goal1.GetValue(
                    ω,
                    iω,
                    w1,
                    Ρ,
                    d1Minus.GetValue(
                        i,
                        ω,
                        ijk,
                        iω,
                        N,
                        niω,
                        x),
                    x)
                +
                goal2.GetValue(
                    v,
                    i,
                    j,
                    k,
                    ω,
                    ijkω,
                    w2,
                    Ρ,
                    d2Minus.GetValue(
                        v,
                        i,
                        j,
                        k,
                        ω,
                        ijkω,
                        A,
                        niω,
                        x),
                    x)
                +
                goal3.GetValue(
                    k,
                    ω,
                    iω,
                    w3,
                    Ρ,
                    IMaxSpan)
                +
                goal4.GetValue(
                    k,
                    ω,
                    iω,
                    w4,
                    Ρ,
                    IMaxSpan,
                    IMinSpan);
        }
    }
}