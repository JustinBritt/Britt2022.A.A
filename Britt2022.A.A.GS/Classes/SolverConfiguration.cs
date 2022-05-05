namespace Britt2022.A.A.GS.Classes
{
    using Britt2022.A.A.GS.Interfaces;

    internal sealed class SolverConfiguration : ISolverConfiguration
    {
        public SolverConfiguration(
            long maximumNumberTicks)
        {
            this.MaximumNumberTicks = maximumNumberTicks;
        }

        public long MaximumNumberTicks { get; }
    }
}