namespace Britt2022.A.A.Results.Classes.SurgeonOperatingRoomDayAssignments
{
    using System;
    using System.Linq;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.Results.Interfaces.SurgeonOperatingRoomDayAssignments;

    public sealed class x : Ix
    {
        public x()
        {
        }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<xResultElement> x)
        {
            xResultElement[] xArray = x.ToArray();

            RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> outerRedBlackTree = new RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>>(
                new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateOrganizationComparerFactory().Create());

            foreach (Organization surgeon in xArray.Select(w => w.Surgeon).Distinct())
            {
                RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> firstInnerRedBlackTree = new RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>(
                    new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateLocationComparerFactory().Create());

                foreach (Location operatingRoom in xArray.Select(w => w.OperatingRoom).Distinct())
                {
                    RedBlackTree<FhirDateTime, INullableValue<bool>> secondInnerRedBlackTree = new RedBlackTree<FhirDateTime, INullableValue<bool>>(
                        new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateFhirDateTimeComparerFactory().Create());

                    foreach (FhirDateTime day in xArray.Select(w => w.Day).Distinct())
                    {
                        secondInnerRedBlackTree.Add(
                            day,
                            nullableValueFactory.Create<bool>(
                                xArray.Where(w => w.Surgeon == surgeon && w.OperatingRoom == operatingRoom && w.Day == day).Select(w => w.Value).SingleOrDefault()));
                    }

                    firstInnerRedBlackTree.Add(
                        operatingRoom,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    surgeon,
                    firstInnerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}