﻿namespace Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonScenarioDeviations
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;

    public interface Id1MinusResultElementFactory
    {
        d1MinusResultElement Create(
            Organization surgeon,
            INullableValue<int> scenario,
            int value);
    }
}