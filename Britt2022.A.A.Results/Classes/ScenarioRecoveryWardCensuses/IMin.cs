﻿namespace Britt2022.A.A.Results.Classes.ScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.Interfaces.ScenarioRecoveryWardCensuses;

    public sealed class IMin : IIMin
    {
        public IMin()
        {
        }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<IMinResultElement> IMin)
        {
            return IMin.ToArray().ToImmutableList()
                .Select(
                w => Tuple.Create(
                    (INullableValue<int>)w.Scenario,
                    nullableValueFactory.Create<decimal>(
                        w.Value)))
                .ToImmutableList();
        }
    }
}