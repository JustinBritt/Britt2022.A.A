namespace Britt2022.A.A.Variables.Factories
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Variables.Classes;
    using Britt2022.A.A.Variables.Interfaces;
    using Britt2022.A.A.Variables.InterfacesFactories;

    internal sealed class d1MinusFactory : Id1MinusFactory
    {
        public d1MinusFactory()
        {
        }

        public Id1Minus Create(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω)
        {
            Id1Minus variable;

            try
            {
                variable = new d1Minus(
                    i,
                    ω);
            }
            finally
            {
            }

            return variable;
        }
    }
}