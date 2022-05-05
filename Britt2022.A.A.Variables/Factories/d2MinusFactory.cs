namespace Britt2022.A.A.Variables.Factories
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Variables.Classes;
    using Britt2022.A.A.Variables.Interfaces;
    using Britt2022.A.A.Variables.InterfacesFactories;

    internal sealed class d2MinusFactory : Id2MinusFactory
    {
        public d2MinusFactory()
        {
        }

        public Id2Minus Create(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω)
        {
            Id2Minus variable;

            try
            {
                variable = new d2Minus(
                    i,
                    j,
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