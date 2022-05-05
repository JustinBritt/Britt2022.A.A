namespace Britt2022.A.A.Variables.Factories
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Variables.Classes;
    using Britt2022.A.A.Variables.Interfaces;
    using Britt2022.A.A.Variables.InterfacesFactories;

    internal sealed class IFactory : IIFactory
    {
        public IFactory()
        {
        }

        public II Create(
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω)
        {
            II variable;

            try
            {
                variable = new I(
                    k,
                    ω);
            }
            finally
            {
            }

            return variable;
        }
    }
}