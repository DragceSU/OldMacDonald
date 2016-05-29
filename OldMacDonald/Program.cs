namespace OldMacDonald
{
    #region

    using System;
    using System.Collections.Generic;

    using Container;

    using Ninject;

    using OldMacDonald.BL;
    using OldMacDonald.Domain;

    #endregion

    internal class Program
    {
        private static readonly Dictionary<string, string> _newAnimals = new Dictionary<string, string>
                                                                             {
                                                                                 {
                                                                                     "lion", 
                                                                                     "raw"
                                                                                 }, 
                                                                                 {
                                                                                     "crocodile", 
                                                                                     "cre"
                                                                                 }, 
                                                                                 {
                                                                                     "antelope", 
                                                                                     "snort"
                                                                                 }, 
                                                                                 {
                                                                                     "bat", 
                                                                                     "screec"
                                                                                 }
                                                                             };

        private static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel();
            InitializeContainer.Register(kernel);

            AnimalManager<AnimalBase> manager = kernel.Get<AnimalManager<AnimalBase>>();
            Console.WriteLine(manager.GetAnimals());

            // Custom animal types in case of user specific definitions
            foreach (KeyValuePair<string, string> animal in _newAnimals)
            {
                Console.WriteLine(AnimalManager<AnimalBase>.InitializeCustomAnimal(animal.Key, animal.Value));
            }
        }
    }
}