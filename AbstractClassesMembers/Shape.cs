using System.Numerics;

namespace AbstractClasses

{
    // - When a class member is declared as abstract, that class needs to be declared as
    // abstract as well.That means that class is not complete.
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // - When a class member is declared as abstract, that class needs to be declared as
        // abstract as well.That means that class is not complete.

        public abstract void Draw();

        // cannot define this if using Abstract class
        // derived class will take control eg. Rectangle : Shape

        public abstract void Print();
        

        public void Copy()
        {
            // this will be the main class
            // we don need the derived class to take control
            Console.WriteLine("Copy shape into clipboard");
        }




    }

}