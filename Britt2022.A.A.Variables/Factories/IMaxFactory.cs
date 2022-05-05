namespace Britt2022.A.A.Variables.Factories
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Variables.Classes;
    using Britt2022.A.A.Variables.Interfaces;
    using Britt2022.A.A.Variables.InterfacesFactories;

    internal sealed class IMaxFactory : IIMaxFactory
    {
        public IMaxFactory()
        {
        }

        public IIMax Create(
            ReadOnlySpan<ωIndexElement> ω)
        {
            IIMax variable;

            try
            {
                variable = new IMax(
                    ω);
            }
            finally
            {
            }

            return variable;
        }
    }
}