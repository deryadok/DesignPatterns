using _02_AbstractFactoryPattern.Abstract;
using _02_AbstractFactoryPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld animalWorld = new AnimalWorld(africa);
            animalWorld.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            animalWorld = new AnimalWorld(america);
            animalWorld.RunFoodChain();


            Console.ReadKey();
        }
    }
}
