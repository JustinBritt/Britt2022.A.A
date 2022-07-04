namespace Britt2022.A.A.Variables.Classes
{
    using System;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public sealed class x : Ix
    {
        public x()
        {
        }

        public unsafe ReadOnlySpan<xResultElement> GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            FhirDateTime[] planningHorizon,
            Location[] operatingRooms,
            Organization[] surgeons,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<xVariableElement> x)
        {
            ReadOnlySpan<xVariableElement> xVariableSpan = x;

            Span<xResultElement> xResultSpan = (Span<xResultElement>)Array.CreateInstance(
                typeof(xResultElement),
                ijk.Length - 1);

            xResultSpan.Clear();

            for (int w = 1; w < ijk.Length; w = w + 1)
            {
                xResultSpan[ijk[w].ijkZI] = new xResultElement(
                    surgeon: surgeons[ijk[w].iIndexElement - 1],
                    operatingRoom: operatingRooms[ijk[w].jIndexElement - 1],
                    day: planningHorizon[ijk[w].kIndexElement - 1],
                    value: Convert.ToBoolean(xVariableSpan[ijk[w].ijkOI].Value));
            }

            return xResultSpan;
        }
    }
}