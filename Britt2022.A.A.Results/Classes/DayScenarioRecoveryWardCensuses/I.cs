namespace Britt2022.A.A.Results.Classes.DayScenarioRecoveryWardCensuses
{
    using System;
    using System.Linq;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.Interfaces.DayScenarioRecoveryWardCensuses;

    public sealed class I : II
    {
        public I()
        {
        }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<IResultElement> I)
        {
            IResultElement[] IArray = I.ToArray();

            RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> outerRedBlackTree = new RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateFhirDateTimeComparerFactory().Create());

            foreach (FhirDateTime day in IArray.Select(w => w.Day).Distinct())
            {
                RedBlackTree<INullableValue<int>, INullableValue<decimal>> innerRedBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<decimal>>(
                    new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateNullableValueintComparerFactory().Create());

                foreach (INullableValue<int> scenario in IArray.Select(w => w.Scenario).DistinctBy(w => w.Value.Value))
                {
                    innerRedBlackTree.Add(
                        scenario,
                        nullableValueFactory.Create<decimal>(
                            IArray.Where(w => w.Day == day && w.Scenario == scenario).Select(w => w.Value).SingleOrDefault()));
                }

                outerRedBlackTree.Add(
                    day,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}
