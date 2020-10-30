using System;

namespace prelim_exam
{
    public class Amphibian : Animal
    {
        //Amphibians are cold-blooded, four-limbed vertebrates within the class Amphibia

        public bool Coldblooded { get; set; }

        public override void GetClass()
        {
            this._class = "Amphibia";
            Console.WriteLine(this._class);
        }

        public override void GetType()
        {
            this._ofType = "Amphibian";
            Console.WriteLine(this._ofType);
        }
    }
    public class Frog : Amphibian,Iamphibian
    {
        public void frog()
        {
            Amphibian frog = new Amphibian();
            frog.Coldblooded = true;
            this._numberOfLegs = 4;
            this.CanSwim = true;
            this.Name = "Froakie ";

            Console.WriteLine("Frog");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);


        }

        public void froginfo()
        {
            Frog frog = new Frog();
            frog.frog();
        }

        public void salamanderinfo()
        {
            
        }
    }


    public class Salamander : Amphibian,Iamphibian
    {

        public void salamander()
        {
            Amphibian salamander = new Amphibian();
            salamander.Coldblooded = true;
            this._numberOfLegs = 4;
            this.CanSwim = true;
            this.Name = "Natsu ";

            Console.WriteLine("Salamander");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);
        }

        public void froginfo()
        {
            throw new NotImplementedException();
        }
        public void salamanderinfo()
        {
            Salamander salamander = new Salamander();
            salamander.salamander();
        }
    }
}
