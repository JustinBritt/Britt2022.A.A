namespace Britt2022.A.A.Comparers.Classes
{
    using System;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Comparers.Interfaces;

    internal sealed class FhirDateTimeComparer : IFhirDateTimeComparer
    {
        public FhirDateTimeComparer()
        {
        }

        public int Compare(
            FhirDateTime x,
            FhirDateTime y)
        {
            return x.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime
                .CompareTo(
                y.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime);
        }
    }
}