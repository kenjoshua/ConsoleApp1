using System;

namespace ConsoleApp1
{
    public class Cat2 : Animal
    {
        public override void Hunt()
        {
            Console.WriteLine("Hunts mice");
        }

        public override void Sound()
        {
            Console.WriteLine("Meow");
        }


    

    }

    public class Persian : Cat2
    {
      
    }

}
