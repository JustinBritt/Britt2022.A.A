namespace Britt2022.A.A.Results.Classes.ScenarioRecoveryWardCensuses
{
    using System;
    using System.Linq;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.Interfaces.ScenarioRecoveryWardCensuses;

    public sealed class IMax : IIMax
    {
        public IMax()
        {
        }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<IMaxResultElement> IMax)
        {
            IMaxResultElement[] IMaxArray = IMax.ToArray();

            RedBlackTree<INullableValue<int>, INullableValue<decimal>> redBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<decimal>>(
                new Britt2022.A.A.Comparers.AbstractFactories.ComparersAbstractFactory().CreateNullableValueintComparerFactory().Create());

            foreach (INullableValue<int> scenario in IMaxArray.Select(w => w.Scenario).DistinctBy(w => w.Value.Value))
            {
                redBlackTree.Add(
                    scenario,
                    nullableValueFactory.Create<decimal>(
                        IMaxArray.Where(w => w.Scenario == scenario).Select(w => w.Value).SingleOrDefault()));
            }

            return redBlackTree;
        }
    }
}