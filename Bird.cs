using System;
using ConsoleApp1;

namespace prelim_exam
{
    //Birds are a collection of warm-blooded vertebrates within the class Aves, identified by feathers, toothless, beaked jaws, the laying of hard-shelled eggs, a four-chambered heart, and a well-built yet lightweight skeleton system.

    public class Bird : Animal
    {
        public bool Hasfeather { get; set; }
        public bool Istoothless { get; set; }
        public bool Hasbeakjaws { get; set; }
        public bool Islaying { get; set; }
        public bool HasfourchamberedHeart { get; set; }
        public bool ISlightweightSkeleton { get; set; }


        public override void GetClass()
        {
            Console.WriteLine("Class: Aves");
        }

        public override void GetType()
        {
            Console.WriteLine("Type: bird");
        }

    }
     public class Eagle : Bird, Ibird
    {
       

        public void eagle()
        {
            Bird agila = new Bird();

            agila.Hasfeather = true;
            agila.Istoothless = true;
            agila.Hasbeakjaws = true;
            agila.Islaying = true;
            agila.HasfourchamberedHeart = true;
            agila.ISlightweightSkeleton = true;
            this._numberOfLegs = 2;
            this.CanSwim = false;
            this.Name = "Eagledie ";

            Console.WriteLine("Eagle");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "has feather: " + agila.Hasfeather);
            Console.WriteLine(this.Name + "is toothless: " + agila.Istoothless);
            Console.WriteLine(this.Name + "has beakjaws: " + agila.Hasbeakjaws);
            Console.WriteLine(this.Name + "is Laying: " + agila.Islaying);
            Console.WriteLine(this.Name + "has four chamberered heart: " + agila.HasfourchamberedHeart);
            Console.WriteLine(this.Name + "is Light weight Skeleton: " + agila.ISlightweightSkeleton);
            Console.WriteLine(this.Name + "legs: : " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can Swim: " + agila.CanSwim);
        }

        public void eagleinfo()
        {
            Eagle eagle = new Eagle();
            eagle.eagle();
        }
        public void doveinfo()
        {

        }
    }

    public class Dove : Bird,Ibird
    {
        public void dove()
        {
            Bird dove = new Bird();

            dove.Hasfeather = true;
            dove.Istoothless = true;
            dove.Hasbeakjaws = true;
            dove.Islaying = true;
            dove.HasfourchamberedHeart = true;
            dove.ISlightweightSkeleton = true;
            this._numberOfLegs = 2;
            this.CanSwim = false;
            this.Name = "Dovie ";

            Console.WriteLine("Dove");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "has feather: " + dove.Hasfeather);
            Console.WriteLine(this.Name + "is toothless: " + dove.Istoothless);
            Console.WriteLine(this.Name + "has beakjaws: " + dove.Hasbeakjaws);
            Console.WriteLine(this.Name + "is Laying: " + dove.Islaying);
            Console.WriteLine(this.Name + "has four chamberered heart: " + dove.HasfourchamberedHeart);
            Console.WriteLine(this.Name + "is Light weight Skeleton: " + dove.ISlightweightSkeleton);
            Console.WriteLine(this.Name + "legs: : " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can Swim: " + dove.CanSwim);
        }

        public void doveinfo()
        {
            Dove dove = new Dove();
            dove.dove();
        }

        public void eagleinfo()
        {
            
        }
    }
}
