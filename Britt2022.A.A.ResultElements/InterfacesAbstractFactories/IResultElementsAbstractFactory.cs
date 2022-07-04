namespace Britt2022.A.A.ResultElements.InterfacesAbstractFactories
{
    using Britt2022.A.A.ResultElements.InterfacesFactories.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.InterfacesFactories.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonScenarioDeviations;

    public interface IResultElementsAbstractFactory
    {
        Id1MinusResultElementFactory Created1MinusResultElementFactory();

        IIResultElementFactory CreateIResultElementFactory();

        IIMaxResultElementFactory CreateIMaxResultElementFactory();

        IIMinResultElementFactory CreateIMinResultElementFactory();

        IxResultElementFactory CreatexResultElementFactory();
    }
}