// See husing System.Collections.Generic;

namespace AbstractClassessPart2

{

     // all child classes must have a public override method
    public class Cat : Animal
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
    {
        public override void Speak()
        {
            Console.WriteLine("The parrot goes uwu");
        }



    }
}
