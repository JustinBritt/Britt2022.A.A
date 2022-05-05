namespace Britt2022.A.A.Results.InterfacesFactories.ObjectiveValue
{
    using Britt2022.A.A.Results.Interfaces.ObjectiveValue;

    public interface IObjectiveValueFactory
    {
        IObjectiveValue Create(
            decimal value);
    }
}