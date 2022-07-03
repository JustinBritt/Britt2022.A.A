﻿namespace Britt2022.A.A.CrossJoinElements.InterfacesFactories
{
    using Britt2022.A.A.CrossJoinElements.Structs;

    public interface IiωCrossJoinElementFactory
    {
        iωCrossJoinElement Create(
            int iIndexElement,
            int ωIndexElement,
            int iωOI,
            int iωZI);
    }
}