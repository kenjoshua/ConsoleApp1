using ConsoleApp1;

namespace prelim_exam
{
    public abstract class Animal
    {

        //TODO: Modify this class so that we can set _class ONLY ONCE 
        public string _class { get; set; }

        //TODO: Modify this class so that we can set _ofType ONLY ONCE
        //_ofType sample: Bird, Fish, Mammal -- all these classes are already provided
        public string _ofType { get; set; }

        //TODO: Modify so that we can set number of legs ONLY ONCE
        //TODO: Must expose the value of _numberOfLegs but not the variable OUTSIDE the class
        public int _numberOfLegs { get; set; }

        public string Name { get; set; }

        //Note: This is a auto-implemented getter-setter
        public bool CanSwim { get; set; }


        public abstract void GetClass();
        public abstract void GetType();
        public  bool HasLegs() => _numberOfLegs > 0;


    }
}
