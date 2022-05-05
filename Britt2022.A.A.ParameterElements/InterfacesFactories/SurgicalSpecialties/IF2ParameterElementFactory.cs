namespace Britt2022.A.A.ParameterElements.InterfacesFactories.SurgicalSpecialties
{
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;

    public interface IF2ParameterElementFactory
    {
        F2ParameterElement Create();

        F2ParameterElement Create(
            int value);
    }
}