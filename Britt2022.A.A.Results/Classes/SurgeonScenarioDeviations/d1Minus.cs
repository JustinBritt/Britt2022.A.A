﻿namespace Britt2022.A.A.Results.Classes.SurgeonScenarioDeviations
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;
    using Britt2022.A.A.Results.Interfaces.SurgeonScenarioDeviations;

    public sealed class d1Minus : Id1Minus
    {
        public d1Minus()
        {
        }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<d1MinusResultElement> d1Minus)
        {
            return d1Minus.ToArray().ToImmutableList()
                .Select(
                w => Tuple.Create(
                    w.Surgeon,
                    (INullableValue<int>)w.Scenario,
                    nullableValueFactory.Create<int>(
                    w.Value)))
                .ToImmutableList();
        }
    }
}