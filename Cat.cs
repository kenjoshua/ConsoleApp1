using System;

namespace ConsoleApp1
{
    //abstraction by interface
    public class Cat : IAnimal
    {
        public int Feet { get; set; }
        public void Hunt()
        {
            Console.WriteLine("Hunts mice");
        }

        public void Sound()
        {
            Console.WriteLine("Meow");
        }
    }


    public class Car : IAnimal
    {
        public int Wheels { get; set; }

        public void Hunt()
        {
            Console.WriteLine("Hunts mice");
        }

        public void Sound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Hunter : IAnimal
    {
        public void Hunt()
        {
            Console.WriteLine("Hunts boars");
        }

        public void Sound()
        {
            Console.WriteLine("(No sound)");
        }
    }

    public class Ranger : Hunter
    {

    }

    public class Dog : IAnimal
    {
        public void Hunt()
        {
            Console.WriteLine("Hunts squirrel");
        }

        public void Sound()
        {
            Console.WriteLine("Arf");
        }
    }


}
