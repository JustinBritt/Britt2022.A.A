namespace Britt2022.A.A.Results.Factories.OverallWallTime
{
    using System;

    using Britt2022.A.A.Results.Classes.OverallWallTime;
    using Britt2022.A.A.Results.Interfaces.OverallWallTime;
    using Britt2022.A.A.Results.InterfacesFactories.OverallWallTime;

    public sealed class OverallWallTimeFactory : IOverallWallTimeFactory
    {
        public OverallWallTimeFactory()
        {
        }

        public IOverallWallTime Create(
            TimeSpan value)
        {
            IOverallWallTime result = null;

            try
            {
                result = new OverallWallTime(
                    value);
            }
            finally
            {
            }

            return result;
        }
    }
}