﻿namespace Britt2022.A.A.LAHC.Interfaces
{
    using Britt2022.A.A.LocalSearch.Interfaces;

    public interface IParameters : ILocalSearchParameters
    {
        int FitnessArrayLength { get; }
    }
}