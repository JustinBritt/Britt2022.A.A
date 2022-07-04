﻿namespace Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonScenarioDeviations
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;

    public interface Id1PlusResultElementFactory
    {
        d1PlusResultElement Create(
            Organization surgeon,
            PositiveInt scenario,
            int value);
    }
}