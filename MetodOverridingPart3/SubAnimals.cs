namespace MethodOveride3

{
    // method overigin rovides a new version of a method inherirted from a parent class
    // inherited method must be abstract, virtual or already overriden


    public class Cat:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes meow");
        }

    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes woof");
        }
    }

    public class Parrot : Animal
    {   // if we dont override, it will use default method
        //public override void Speak()
        //{
        // Console.WriteLine("The parrot goes uwu");
        //}
    }




}
