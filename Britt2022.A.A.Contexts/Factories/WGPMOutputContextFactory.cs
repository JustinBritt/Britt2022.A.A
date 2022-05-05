namespace Britt2022.A.A.Contexts.Factories
{
    using System;

    using Britt2022.A.A.Contexts.Classes;
    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.Contexts.InterfacesFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.ResultElements.Structs.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;

    public sealed class WGPMOutputContextFactory : IWGPMOutputContextFactory
    {
        public WGPMOutputContextFactory()
        {
        }

        public IWGPMOutputContext Create(
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ReadOnlySpan<d1MinusResultElement> d1Minus,
            ReadOnlySpan<d1PlusResultElement> d1Plus,
            ReadOnlySpan<d2MinusResultElement> d2Minus,
            ReadOnlySpan<IResultElement> I,
            ReadOnlySpan<IMaxResultElement> IMax,
            ReadOnlySpan<IMinResultElement> IMin,
            decimal objectiveValue,
            TimeSpan overallWallTime,
            ReadOnlySpan<xResultElement> x)
        {
            IWGPMOutputContext context = null;

            try
            {
                context = new WGPMOutputContext(
                    dependenciesAbstractFactory,
                    resultsAbstractFactory,
                    d1Minus,
                    d1Plus,
                    d2Minus,
                    I,
                    IMax,
                    IMin,
                    objectiveValue,
                    overallWallTime,
                    x);
            }
            finally
            {
            }

            return context;
        }
    }
}