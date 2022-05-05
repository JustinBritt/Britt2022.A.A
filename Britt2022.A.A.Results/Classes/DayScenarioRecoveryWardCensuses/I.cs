namespace Britt2022.A.A.Results.Classes.DayScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.Interfaces.DayScenarioRecoveryWardCensuses;

    public sealed class I : II
    {
        public I()
        {
        }

        public ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<IResultElement> I)
        {
            return I.ToArray().ToImmutableList()
                .Select(
                w => Tuple.Create(
                    w.Day,
                    (INullableValue<int>)w.Scenario,
                    nullableValueFactory.Create<decimal>(
                        w.Value)))
                .ToImmutableList();
        }
    }
}
