namespace Britt2022.A.A.Results.Classes.SurgeonOperatingRoomDayScenarioDeviations
{
    using System;
    using System.Linq;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.Results.Interfaces.SurgeonOperatingRoomDayScenarioDeviations;

    public sealed class d2Minus : Id2Minus
    {
        public d2Minus()
        {
        }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<d2MinusResultElement> d2Minus)
        {
            d2MinusResultElement[] d2MinusArray = d2Minus.ToArray();

            RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>> outerRedBlackTree = new RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>>(
                new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateOrganizationComparerFactory().Create());

            foreach (Organization surgeon in d2MinusArray.Select(w => w.Surgeon).Distinct())
            {
                RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> firstInnerRedBlackTree = new RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>(
                    new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateLocationComparerFactory().Create());

                foreach (Location operatingRoom in d2MinusArray.Select(w => w.OperatingRoom).Distinct())
                {
                    RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> secondInnerRedBlackTree = new RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                        new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateFhirDateTimeComparerFactory().Create());

                    foreach (FhirDateTime day in d2MinusArray.Select(w => w.Day).Distinct())
                    {
                        RedBlackTree<INullableValue<int>, INullableValue<decimal>> thirdInnerRedBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<decimal>>(
                            new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateNullableValueintComparerFactory().Create());

                        foreach (INullableValue<int> scenario in d2MinusArray.Select(w => w.Scenario).Distinct())
                        {
                            thirdInnerRedBlackTree.Add(
                                scenario,
                                nullableValueFactory.Create<decimal>(
                                d2MinusArray.Where(w => w.Surgeon == surgeon && w.OperatingRoom == operatingRoom && w.Day == day && w.Scenario == scenario).Select(w => w.Value).SingleOrDefault()));
                        }

                        secondInnerRedBlackTree.Add(
                            day,
                            thirdInnerRedBlackTree);
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