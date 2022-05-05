namespace Britt2022.A.A.Results.Classes.OverallWallTime
{
    using System;

    using Britt2022.A.A.Results.Interfaces.OverallWallTime;

    internal sealed class OverallWallTime : IOverallWallTime
    {
        public OverallWallTime(
            TimeSpan value)
        {
            this.Value = value;
        }

        public TimeSpan Value { get; }
    }
}