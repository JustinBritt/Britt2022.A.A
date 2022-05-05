namespace Britt2022.A.A.ParameterElements.InterfacesAbstractFactories
{
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.Surgeries;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.SurgicalSpecialties;

    public interface IParameterElementsAbstractFactory
    {
        IAParameterElementFactory CreateAParameterElementFactory();

        IB1ParameterElementFactory CreateB1ParameterElementFactory();

        IBParameterElementFactory CreateBParameterElementFactory();

        IF2ParameterElementFactory CreateF2ParameterElementFactory();

        IhiParameterElementFactory CreatehiParameterElementFactory();

        IHParameterElementFactory CreateHParameterElementFactory();

        ILParameterElementFactory CreateLParameterElementFactory();

        IniωParameterElementFactory CreateniωParameterElementFactory();

        INParameterElementFactory CreateNParameterElementFactory();

        IpParameterElementFactory CreatepParameterElementFactory();

        IΠParameterElementFactory CreateΠParameterElementFactory();

        IΡParameterElementFactory CreateΡParameterElementFactory();

        IΦParameterElementFactory CreateΦParameterElementFactory();

        IΩParameterElementFactory CreateΩParameterElementFactory();
    }
}