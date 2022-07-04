namespace Britt2022.A.A.ResultElements.AbstractFactories
{
    using Britt2022.A.A.ResultElements.Factories.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Factories.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Factories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.ResultElements.Factories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.ResultElements.Factories.SurgeonScenarioDeviations;
    using Britt2022.A.A.ResultElements.InterfacesAbstractFactories;
    using Britt2022.A.A.ResultElements.InterfacesFactories.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.InterfacesFactories.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonScenarioDeviations;

    public sealed class ResultElementsAbstractFactory : IResultElementsAbstractFactory
    {
        public ResultElementsAbstractFactory()
        {
        }

        public Id1MinusResultElementFactory Created1MinusResultElementFactory()
        {
            Id1MinusResultElementFactory factory = null;

            try
            {
                factory = new d1MinusResultElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIResultElementFactory CreateIResultElementFactory()
        {
            IIResultElementFactory factory = null;

            try
            {
                factory = new IResultElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIMaxResultElementFactory CreateIMaxResultElementFactory()
        {
            IIMaxResultElementFactory factory = null;

            try
            {
                factory = new IMaxResultElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIMinResultElementFactory CreateIMinResultElementFactory()
        {
            IIMinResultElementFactory factory = null;

            try
            {
                factory = new IMinResultElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IxResultElementFactory CreatexResultElementFactory()
        {
            IxResultElementFactory factory = null;

            try
            {
                factory = new xResultElementFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}