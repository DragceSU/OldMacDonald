#region

using Ninject;
using OldMacDonald.BL;
using OldMacDonald.Domain;
using OldMacDonald.Interfaces.BL;

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