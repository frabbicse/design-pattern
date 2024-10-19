using AbstractFactoryDesignPattern;
using AbstractFactoryDesignPattern.Example_2;
using AbstractFactoryDesignPattern.Example_2.Concrete_Class;

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattenLearning.Patterns
{
    public class AbstractFactoryDesignPatternHelper
    {
        public static void HelperMain()
        {
            Animal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;
            // Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            Console.WriteLine("--------------------------");

            // Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();

            // Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal("Cat");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.Read();

        }

        public static void AbstractMethodExample2()
        {
            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);
            Console.WriteLine("*************NOKIA *************");

            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            IMobilePhone samsungMobilePhne = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhne);


            Console.WriteLine("*************SAMSUNG *************");

            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

            Console.ReadKey();
        }
    }
}
