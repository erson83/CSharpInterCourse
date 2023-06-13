namespace MethodOveride

{


    class Program

    {

//        - Method overriding means changing the implementation of an inherited method.
//- If a declare a method as virtual in the base class, we can override it in a derived
//class.

        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

        }


    }




}