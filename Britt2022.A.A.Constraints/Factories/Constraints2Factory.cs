namespace Britt2022.A.A.Constraints.Factories
{
    using Britt2022.A.A.Constraints.Classes;
    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesFactories;

    internal sealed class Constraints2Factory : IConstraints2Factory
    {
        public Constraints2Factory()
        {
        }

        public IConstraints2 Create()
        {
            IConstraints2 constraints = null;

            try
            {
                constraints = new Constraints2();
            }
            finally
            {
            }

            return constraints;
        }
    }
}