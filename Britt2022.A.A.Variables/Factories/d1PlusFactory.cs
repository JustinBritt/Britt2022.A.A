namespace Britt2022.A.A.Variables.Factories
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Variables.Classes;
    using Britt2022.A.A.Variables.Interfaces;
    using Britt2022.A.A.Variables.InterfacesFactories;

    public sealed class d1PlusFactory : Id1PlusFactory
    {
        public d1PlusFactory()
        {
        }

        public Id1Plus Create(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω)
        {
            Id1Plus variable;

            try
            {
                variable = new d1Plus(
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