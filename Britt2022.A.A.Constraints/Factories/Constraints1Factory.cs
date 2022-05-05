namespace Britt2022.A.A.Constraints.Factories
{
    using Britt2022.A.A.Constraints.Classes;
    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesFactories;

    internal sealed class Constraints1Factory : IConstraints1Factory
    {
        public Constraints1Factory()
        {
        }

        public IConstraints1 Create()
        {
            IConstraints1 constraints = null;

            try
            {
                constraints = new Constraints1();
            }
            finally
            {
            }

            return constraints;
        }
    }
}