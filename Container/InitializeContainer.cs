namespace Container
{
    using Ninject;

    using OldMacDonald.BL;
    using OldMacDonald.BL.Interfaces;
    using OldMacDonald.Domain;

    public class InitializeContainer
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<IAnimalManager<AnimalBase>>().To<AnimalManager<AnimalBase>>().InSingletonScope();
        }
    }
}