using System;
using ConsoleApp1;

namespace prelim_exam
{
    public class Fish : Animal
    {
        //Fishes are the aquatic animals within the class Anatidae that do not have limbs with digits.
        public int Limbs { get; set; }

        public override void GetClass()
        {
            this._class = "Anatidae";
            Console.WriteLine("Class: " + this._class);
        }

        public override void GetType()
        {
            this._ofType = "Fish";
            Console.WriteLine("Type: " + this._ofType);
        }
    }
    class Goldfish : Fish, Ifish
    {
       

        public void gintongisda()
        {
            Goldfish isda = new Goldfish();
            this.Name = "Ginto ";
            this._numberOfLegs = 0;
            this.CanSwim = true;

            Console.WriteLine("Goldfish");
            Console.WriteLine("Name: "+ this.Name);
            Console.WriteLine(this.Name + "Legs: " + _numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);

        }

        public void goldfishinfo()
        {
            Goldfish isda = new Goldfish();
            isda.gintongisda();
        }
        public void carpinfo()
        {
            
        }
        
    }
    public class Carp : Fish,Ifish
    {
        public void carp()
        {
            Goldfish carp = new Goldfish();
            this.Name = "Carpa ";
            this._numberOfLegs = 0;
            this.CanSwim = true;

            Console.WriteLine("Carp");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "Legs: " + _numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);

        }

        public void carpinfo()
        {
            Carp carp = new Carp();
            carp.carp();
        }

        public void goldfishinfo()
        {
           
        }
    }
}
