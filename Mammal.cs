using System;
using ConsoleApp1;

namespace prelim_exam
{
    public class Mammal : Animal
    {


        // Mammals are vertebrates within the class Mammalia which have a neocortex (i.e., higher brain functions), hair, three middle ear bones, and mammary glands.

        public bool IsVertebrate { get; set; }
        public bool HasNeocortex { get; set; }
        public bool HasHair { get; set; }
        public bool HasThreeMiddleEarBones { get; set; }
        public bool HasMammaryGland { get; set; }


        public override void GetClass()
        {
            this._class = "Mammalia";
            Console.WriteLine("Class: " + this._class);
        }

        public override void GetType()
        {
            this._ofType = "Mammal";
            Console.WriteLine("Type: " + this._ofType);
        }
      

    }

    public class Dog : Mammal, Imammal

    {

        public void aso()
        {
            Dog aso = new Dog();
            aso.Name = "Doggie ";
            aso.IsVertebrate = true;
            aso.HasNeocortex = true;
            aso.HasHair = true;
            aso.HasThreeMiddleEarBones = true;
            aso.HasMammaryGland = true;
            this._numberOfLegs = 4;
            this.CanSwim = true;

            Console.WriteLine("Dog");
            Console.WriteLine("Name: " + aso.Name);
            Console.WriteLine(this.Name + "is Vertebrate: " + aso.IsVertebrate);
            Console.WriteLine(this.Name + "is Has Neocortex: " + aso.HasNeocortex);
            Console.WriteLine(this.Name + "has hair: " + aso.HasHair);
            Console.WriteLine(this.Name + "has three middle ear bone: " + aso.HasThreeMiddleEarBones);
            Console.WriteLine(this.Name + "has mammarygland: " + aso.HasMammaryGland);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);



        }

        public void catinfo()
        {
          

        }

        public void doginfo()
        {
            Dog aso = new Dog();
            aso.aso();

        }
    }
    public class Cat : Mammal, Imammal

    {
       

        public void pusa()
        {
            Cat pusa = new Cat();
            this.Name = "Cattie ";
            pusa.IsVertebrate = true;
            pusa.HasNeocortex = true;
            pusa.HasHair = true;
            pusa.HasThreeMiddleEarBones = true;
            pusa.HasMammaryGland = true;
            this._numberOfLegs = 4;
            this.CanSwim = true;

            Console.WriteLine("Cat");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "is Vertebrate: " + pusa.IsVertebrate);
            Console.WriteLine(this.Name + "Has Neocortex: " + pusa.HasNeocortex);
            Console.WriteLine(this.Name + "has hair: " + pusa.HasHair);
            Console.WriteLine(this.Name + "has three middle ear bone: " + pusa.HasThreeMiddleEarBones);
            Console.WriteLine(this.Name + "has mammarygland: " + pusa.HasMammaryGland);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);


        }
        public void catinfo()
        {
            Cat cat = new Cat();
            cat.pusa();
        }

        public void doginfo()
        {

        }


    }

}

