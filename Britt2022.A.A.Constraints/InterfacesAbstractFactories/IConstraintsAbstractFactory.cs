namespace Britt2022.A.A.Constraints.InterfacesAbstractFactories
{
    using Britt2022.A.A.Constraints.InterfacesFactories;

    public interface IConstraintsAbstractFactory
    {
        IConstraintsFactory CreateConstraintsFactory();

        IConstraints1Factory CreateConstraints1Factory();

        IConstraints2Factory CreateConstraints2Factory();

        IConstraints3Factory CreateConstraints3Factory();

        IConstraints4Factory CreateConstraints4Factory();

        IConstraints5LFactory CreateConstraints5LFactory();

        IConstraints5UFactory CreateConstraints5UFactory();

        IConstraints9Factory CreateConstraints9Factory();
    }
}