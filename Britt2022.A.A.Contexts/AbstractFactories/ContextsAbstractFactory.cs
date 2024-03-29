﻿namespace Britt2022.A.A.Contexts.AbstractFactories
{
    using Britt2022.A.A.Contexts.Factories;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.InterfacesFactories;

    public sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        public ContextsAbstractFactory()
        {
        }

        public IPlanningHorizonVisitorFactory CreatePlanningHorizonVisitorFactory()
        {
            IPlanningHorizonVisitorFactory factory = null;

            try
            {
                factory = new PlanningHorizonVisitorFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitorFactory CreateSurgeonDayScenarioCumulativeNumberPatientsOuterVisitorFactory()
        {
            ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitorFactory factory = null;

            try
            {
                factory = new SurgeonDayScenarioCumulativeNumberPatientsOuterVisitorFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IWGPMInputContextFactory CreateWGPMInputContextFactory()
        {
            IWGPMInputContextFactory factory = null;

            try
            {
                factory = new WGPMInputContextFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IWGPMOutputContextFactory CreateWGPMOutputContextFactory()
        {
            IWGPMOutputContextFactory factory = null;

            try
            {
                factory = new WGPMOutputContextFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}