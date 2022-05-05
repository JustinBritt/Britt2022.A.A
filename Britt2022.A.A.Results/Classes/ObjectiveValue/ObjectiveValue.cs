namespace Britt2022.A.A.Results.Classes.ObjectiveValue
{
    using Britt2022.A.A.Results.Interfaces.ObjectiveValue;

    public sealed class ObjectiveValue : IObjectiveValue
    {
        public ObjectiveValue(
            decimal value)
        {
            this.Value = value;
        }

        public decimal Value { get; }
    }
}