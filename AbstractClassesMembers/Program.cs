using System;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
namespace AbstractClasses
{


    class Program

    {

//        - Abstract modifier states that a class or a member misses implementation.We use
//abstract members when it doesn’t make sense to implement them in a base class. For
//example, the concept of drawing a shape is too abstract. We don’t know how to draw
//a shape.This needs to be implemented in the derived classes.
//- When a class member is declared as abstract, that class needs to be declared as
//abstract as well.That means that class is not complete.
//- In derived classes, we need to override the abstract members in the base class.

        static void Main(string[] args)
        {
            // remember this is different if we use abstract
            // we cannot instatiate Shape
            // we cannot - var shape = new Shape();


            var circle = new Circle();
            circle.Draw();


            var rectangle = new Rectangle();
            rectangle.Draw();

            rectangle.Copy();


            var triangle = new Triangle();
            triangle.Print();

        }

    }


}