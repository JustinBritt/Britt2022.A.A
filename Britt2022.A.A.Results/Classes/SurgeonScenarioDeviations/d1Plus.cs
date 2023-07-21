namespace Britt2022.A.A.Results.Classes.SurgeonScenarioDeviations
{
    using System;
    using System.Linq;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;
    using Britt2022.A.A.Results.Interfaces.SurgeonScenarioDeviations;

    public sealed class d1Plus : Id1Plus
    {
        public d1Plus()
        {
        }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<d1PlusResultElement> d1Plus)
        {
            d1PlusResultElement[] d1PlusArray = d1Plus.ToArray();

            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> outerRedBlackTree = new RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateOrganizationComparerFactory().Create());

            foreach (Organization surgeon in d1PlusArray.Select(w => w.Surgeon).Distinct())
            {
                RedBlackTree<INullableValue<int>, INullableValue<decimal>> innerRedBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<decimal>>(
                    new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateNullableValueintComparerFactory().Create());

                foreach (INullableValue<int> scenario in d1PlusArray.Select(w => w.Scenario).DistinctBy(w => w.Value.Value))
                {
                    innerRedBlackTree.Add(
                        scenario,
                        nullableValueFactory.Create<decimal>(
                            d1PlusArray.Where(w => w.Surgeon == surgeon && w.Scenario == scenario).Select(w => w.Value).SingleOrDefault()));
                }

                outerRedBlackTree.Add(
                    surgeon,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}