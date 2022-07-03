﻿namespace Britt2022.A.A.VariableElements.InterfacesFactories
{
    using Britt2022.A.A.VariableElements.Structs;

    public interface IxVariableElementFactory
    {
        xVariableElement Create(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int value);
    }
}