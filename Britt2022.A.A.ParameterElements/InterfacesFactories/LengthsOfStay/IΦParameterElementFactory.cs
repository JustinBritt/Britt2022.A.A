﻿namespace Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay
{
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    public interface IΦParameterElementFactory
    {
        ΦParameterElement Create(
            int iIndexElement,
            int lIndexElement,
            int ωIndexElement,
            double value);
    }
}