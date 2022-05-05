namespace Britt2022.A.A.Results.InterfacesAbstractFactories
{
    using Britt2022.A.A.Results.InterfacesFactories.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.InterfacesFactories.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonScenarioDeviations;

    public interface IResultsAbstractFactory
    {
        Id1MinusFactory Created1MinusFactory();

        Id1PlusFactory Created1PlusFactory();

        Id2MinusFactory Created2MinusFactory();

        IIFactory CreateIFactory();

        IIMaxFactory CreateIMaxFactory();

        IIMinFactory CreateIMinFactory();

        IxFactory CreatexFactory();
    }
}