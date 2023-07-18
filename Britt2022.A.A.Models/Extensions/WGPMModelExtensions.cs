namespace Britt2022.A.A.Models.Extensions
{
    using Britt2022.A.A.Models.Interfaces;

    public static class WGPMModelExtensions
    {
        public static double GetObjectiveFunctionValue(
            this IWGPMModel WGPMModel)
        {
            return WGPMModel.ObjectiveFunction.GetValue(
                WGPMModel.Geti(),
                WGPMModel.Getj(),
                WGPMModel.Getk(),
                WGPMModel.Getl(),
                WGPMModel.Getω(),
                WGPMModel.Getijk(),
                WGPMModel.Getijkω(),
                WGPMModel.Getilω(),
                WGPMModel.Getiω(),
                WGPMModel.Getkω(),
                WGPMModel.GetA(),
                WGPMModel.GetN(),
                WGPMModel.Getn(),
                WGPMModel.Getv(),
                WGPMModel.Getw1(),
                WGPMModel.Getw2(),
                WGPMModel.Getw3(),
                WGPMModel.Getw4(),
                WGPMModel.GetΡ(),
                WGPMModel.SurgeonDayScenarioCumulativeNumberPatients,
                WGPMModel.d1Minus,
                WGPMModel.d2Minus,
                WGPMModel.I,
                WGPMModel.IMax,
                WGPMModel.IMin,
                WGPMModel.GetxWithoutClearing(),
                WGPMModel.Goal1,
                WGPMModel.Goal2,
                WGPMModel.Goal3,
                WGPMModel.Goal4);
        }
    }
}