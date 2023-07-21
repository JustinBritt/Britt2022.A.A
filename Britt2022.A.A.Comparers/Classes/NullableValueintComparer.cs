namespace Britt2022.A.A.Comparers.Classes
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.Comparers.Interfaces;

    internal sealed class NullableValueintComparer : INullableValueintComparer
    {
        public NullableValueintComparer()
        {
        }

        public int Compare(
            INullableValue<int> x,
            INullableValue<int> y)
        {
            return x.Value.Value.CompareTo(
                y.Value.Value);
        }
    }
}