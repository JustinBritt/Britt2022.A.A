﻿namespace Britt2022.A.A.Results.Interfaces.ScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;

    public interface IIMax
    {
        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<IMaxResultElement> IMax);
    }
}