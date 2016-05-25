#region

using Ninject;
using OldMacDonald.BL;
using OldMacDonald.BL.Interfaces;
using OldMacDonald.Domain;

#endregion

namespace Container
{
    public class InitializeContainer
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<IAnimalManager<AnimalBase>>().To<AnimalManager<AnimalBase>>().InSingletonScope();
        }
    }
}