﻿namespace Britt2022.A.A.CrossJoinElements.InterfacesFactories
{
    using Britt2022.A.A.CrossJoinElements.Structs;

    public interface IkωCrossJoinElementFactory
    {
        kωCrossJoinElement Create(
            int kIndexElement,
            int ωIndexElement,
            int kωOI,
            int kωZI);
    }
}