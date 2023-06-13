namespace MethodOveride

{
    public class Circle : Shape
    {
    public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }


    // create new shapes by adding only a new class
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }


    public class Shape
    {

       public int Height { get; set; }
        public int Width { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }

    }



    public enum Position
    {
        X,
        Y
    }


}