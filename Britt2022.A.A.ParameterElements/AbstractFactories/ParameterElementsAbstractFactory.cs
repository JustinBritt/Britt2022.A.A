namespace Britt2022.A.A.ParameterElements.AbstractFactories
{
    using Britt2022.A.A.ParameterElements.Factories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Factories.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Factories.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Factories.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Factories.Surgeries;
    using Britt2022.A.A.ParameterElements.Factories.SurgicalSpecialties;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.Surgeries;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.SurgicalSpecialties;

    public sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        public ParameterElementsAbstractFactory()
        {
        }

        public IAParameterElementFactory CreateAParameterElementFactory()
        {
            IAParameterElementFactory factory = null;

            try
            {
                factory = new AParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IB1ParameterElementFactory CreateB1ParameterElementFactory()
        {
            IB1ParameterElementFactory factory = null;

            try
            {
                factory = new B1ParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IBParameterElementFactory CreateBParameterElementFactory()
        {
            IBParameterElementFactory factory = null;

            try
            {
                factory = new BParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IF2ParameterElementFactory CreateF2ParameterElementFactory()
        {
            IF2ParameterElementFactory factory = null;

            try
            {
                factory = new F2ParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IhiParameterElementFactory CreatehiParameterElementFactory()
        {
            IhiParameterElementFactory factory = null;

            try
            {
                factory = new hiParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IHParameterElementFactory CreateHParameterElementFactory()
        {
            IHParameterElementFactory factory = null;

            try
            {
                factory = new HParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ILParameterElementFactory CreateLParameterElementFactory()
        {
            ILParameterElementFactory factory = null;

            try
            {
                factory = new LParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IniωParameterElementFactory CreateniωParameterElementFactory()
        {
            IniωParameterElementFactory factory = null;

            try
            {
                factory = new niωParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public INParameterElementFactory CreateNParameterElementFactory()
        {
            INParameterElementFactory factory = null;

            try
            {
                factory = new NParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IpParameterElementFactory CreatepParameterElementFactory()
        {
            IpParameterElementFactory factory = null;

            try
            {
                factory = new pParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IΠParameterElementFactory CreateΠParameterElementFactory()
        {
            IΠParameterElementFactory factory = null;

            try
            {
                factory = new ΠParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IΡParameterElementFactory CreateΡParameterElementFactory()
        {
            IΡParameterElementFactory factory = null;

            try
            {
                factory = new ΡParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IΦParameterElementFactory CreateΦParameterElementFactory()
        {
            IΦParameterElementFactory factory = null;

            try
            {
                factory = new ΦParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IΩParameterElementFactory CreateΩParameterElementFactory()
        {
            IΩParameterElementFactory factory = null;

            try
            {
                factory = new ΩParameterElementFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}