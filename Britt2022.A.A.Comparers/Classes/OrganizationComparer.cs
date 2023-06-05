namespace Britt2022.A.A.Comparers.Classes
{
    using System;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Comparers.Interfaces;

    internal sealed class OrganizationComparer : IOrganizationComparer
    {
        public OrganizationComparer()
        {
        }

        public int Compare(
            Organization x,
            Organization y)
        {
            return String.CompareOrdinal(
                x.Id,
                y.Id);
        }
    }
}