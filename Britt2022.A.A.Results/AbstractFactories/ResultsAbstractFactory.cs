namespace Britt2022.A.A.Results.AbstractFactories
{
    using Britt2022.A.A.Results.Factories.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.Factories.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.Factories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.Results.Factories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.Results.Factories.SurgeonScenarioDeviations;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;
    using Britt2022.A.A.Results.InterfacesFactories.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.InterfacesFactories.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonScenarioDeviations;

    public sealed class ResultsAbstractFactory : IResultsAbstractFactory
    {
        public ResultsAbstractFactory()
        {
        }

        public Id1MinusFactory Created1MinusFactory()
        {
            Id1MinusFactory factory = null;

            try
            {
                factory = new d1MinusFactory();
            }
            finally
            {
            }

            return factory;
        }

        public Id1PlusFactory Created1PlusFactory()
        {
            Id1PlusFactory factory = null;

            try
            {
                factory = new d1PlusFactory();
            }
            finally
            {
            }

            return factory;
        }

        public Id2MinusFactory Created2MinusFactory()
        {
            Id2MinusFactory factory = null;

            try
            {
                factory = new d2MinusFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIFactory CreateIFactory()
        {
            IIFactory factory = null;

            try
            {
                factory = new IFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIMaxFactory CreateIMaxFactory()
        {
            IIMaxFactory factory = null;

            try
            {
                factory = new IMaxFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIMinFactory CreateIMinFactory()
        {
            IIMinFactory factory = null;

            try
            {
                factory = new IMinFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IxFactory CreatexFactory()
        {
            IxFactory factory = null;

            try
            {
                factory = new xFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}