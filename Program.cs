using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace prelim_exam
{

    class Program 
    {
        static void Main(string[] args)
        {
            Dog aso = new Dog();
            aso.GetClass();
            aso.GetType();
            aso.doginfo();

            Console.WriteLine("");
            
            Cat cat = new Cat();
            cat.GetClass();
            cat.GetType();
            cat.catinfo();

            Console.WriteLine("");

            Eagle eagle = new Eagle();
            eagle.GetClass();
            eagle.GetType();
            eagle.eagleinfo();

            Console.WriteLine("");

            Dove dove = new Dove();
            dove.GetClass();
            dove.GetType();
            dove.doveinfo();
            

            Console.WriteLine("");

            Goldfish goldfish = new Goldfish();
            goldfish.GetClass();
            goldfish.GetType();
            goldfish.goldfishinfo();

            Console.WriteLine("");

            Carp carp = new Carp();
            carp.GetClass();
            carp.GetType();
            carp.carpinfo();
        }

    }
}
