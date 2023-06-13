using System.Collections.Generic;

namespace MethodOveride4

{


    class Program

    {

        static void Main(string[] args)
        {
            // declare new class

            var animal = new List<Animals>();

            // add animals into List<Animals>()

            animal.Add(new Dog());
            animal.Add(new Cat());
            animal.Add(new Parrot());
            // after adding animal into List<Animals>. perform List method by looping
            // through list

            var loopthroughlist = new LoopThroughList();
            loopthroughlist.SpeakAnimals(animal);



        }


    }




}
