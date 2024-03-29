﻿namespace Britt2022.A.A.ParameterElements.Factories.StrategicTargets
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;

    internal sealed class HParameterElementFactory : IHParameterElementFactory
    {
        public HParameterElementFactory()
        {
        }

        public HParameterElement Create(
            int iIndexElement,
            int value)
        {
            HParameterElement parameterElement;

            try
            {
                parameterElement = new HParameterElement(
                    iIndexElement: iIndexElement,
                    value: value);
            }
            finally
            {
            }

            return parameterElement;
        }
    }
}