namespace Britt2022.A.A.Variables.Factories
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Variables.Classes;
    using Britt2022.A.A.Variables.Interfaces;
    using Britt2022.A.A.Variables.InterfacesFactories;

    internal sealed class IMinFactory : IIMinFactory
    {
        public IMinFactory()
        {
        }

        public IIMin Create(
            ReadOnlySpan<ωIndexElement> ω)
        {
            IIMin variable;

            try
            {
                variable = new IMin(
                    ω);
            }
            finally
            {
            }

            return variable;
        }
    }
}