using System.Collections.Generic;

namespace MethodOveride3

{

//    - Method overriding means changing the implementation of an inherited method.
//- If a declare a method as virtual in the base class, we can override it in a derived
//class.

    class Program

    {

        static void Main(string[] args)
        {
            var dog = new Dog();
            var cat = new Cat();
            var parrot = new Parrot();

            dog.Speak();

            cat.Speak();

            parrot.Speak();


        }


    }




}
