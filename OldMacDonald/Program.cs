#region

using System;
using System.Collections.Generic;
using Container;
using Ninject;
using OldMacDonald.BL;
using OldMacDonald.Domain;

#endregion

namespace OldMacDonald
{
    internal class Program
    {
        private static readonly Dictionary<string, string> _newAnimals = new Dictionary<string, string>
        {
            {"lion", "raw"},
            {"crocodile", "cre"},
            {"antelope", "snort"},
            {"bat", "screec"}
        };

        private static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            InitializeContainer.Register(kernel);

            var manager = kernel.Get<AnimalManager<AnimalBase>>();
            manager.GetAnimals(manager);

            // Custom animal types in case of user specific definitions
            foreach (var animal in _newAnimals)
            {
                Console.WriteLine(AnimalBase.GetInternalAnimalNameAndSound(animal.Key, animal.Value));
            }
        }
    }
}