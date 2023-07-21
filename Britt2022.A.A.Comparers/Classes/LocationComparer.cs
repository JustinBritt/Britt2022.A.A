namespace Britt2022.A.A.Comparers.Classes
{
    using System;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Comparers.Interfaces;

    internal sealed class LocationComparer : ILocationComparer
    {
        public LocationComparer()
        {
        }

        public int Compare(
            Location x,
            Location y)
        {
            return String.CompareOrdinal(
                x.Id,
                y.Id);
        }
    }
}