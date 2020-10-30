using System;

namespace prelim_exam
{
    public class Reptile : Animal
    {
        //Reptiles are four-limbed (aka tetrapod) animals within the class Reptilia

        public override void GetClass()
        {
            this._class = "Reptilia";
            Console.WriteLine("Class: " + this._class);
        }

        public override void GetType()
        {
            this._ofType = "Reptile";
            Console.WriteLine("Type: " + this._ofType);
        }
    }


    public class Lizard : Reptile,Ireptile
    {
        public void butiki()
        {
            this._numberOfLegs = 4;
            this.Name = "Tiki";
            this.CanSwim = false;

            Console.WriteLine("Lizard");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);
        }

        public void lizardinfo()
        {
            Lizard lizard = new Lizard();
            lizard.butiki();
        }

        public void turtleinfo()
        {
           
        }
    }


    public class Turtle : Reptile,Ireptile
    {
      

        public void pagong()
        {
            this._numberOfLegs = 4;
            this.Name = "Squirtle";
            this.CanSwim = true;

            Console.WriteLine("Turtle");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);
        }

        public void lizardinfo()
        {
            throw new NotImplementedException();
        }

        public void turtleinfo()
        {
            Turtle turtle = new Turtle();
            turtle.pagong();
        }
    }

}
