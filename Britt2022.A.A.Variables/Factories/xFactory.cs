namespace Britt2022.A.A.Variables.Factories
{
    using Britt2022.A.A.Variables.Classes;
    using Britt2022.A.A.Variables.Interfaces;
    using Britt2022.A.A.Variables.InterfacesFactories;

    internal sealed class xFactory : IxFactory
    {
        public xFactory()
        {
        }

        public Ix Create()
        {
            Ix variable;

            try
            {
                variable = new x();
            }
            finally
            {
            }

            return variable;
        }
    }
}