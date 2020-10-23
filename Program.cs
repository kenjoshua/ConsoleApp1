using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<Chimera>();


            Chimera pitou = new Lion();
            Chimera snake = new Snake();
            Chimera goat = new Goat();

            Simba simba = new Simba();

            list.Add(pitou);
            list.Add(snake);
            list.Add(goat);
            list.Add(simba);

            foreach(var s in list)
            {
                if(s is Snake)
                {
                    s.Attack();
                }
            }

            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Chimera
    {
        public abstract void Attack();
    }

    public class Lion : Chimera
    {
        public override void Attack()
        {
            Console.WriteLine("Bite on the neck.");
        }
    }

    public class Simba : Lion
    {
        public override void Attack()
        {
            Console.WriteLine("Bite on the neck with feelings.");
        }

        public void Attack(string message)
        {
            Console.WriteLine("Bite with" + message);
        }
    }

    public class Goat : Chimera
    {
        public override void Attack()
        {
            throw new NotImplementedException();
        }
    }

    public class Snake : Chimera
    {
        public override void Attack()
        {
            Console.WriteLine("Snake bite.");
        }
    }
}
