namespace Britt2022.A.A.Results.InterfacesFactories.OverallWallTime
{
    using System;

    using Britt2022.A.A.Results.Interfaces.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
            TimeSpan value);
    }
}