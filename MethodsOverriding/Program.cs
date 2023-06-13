namespace MethodOveride

{


    class Program

    {

        // before implementing method overiding
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle });
            shapes.Add(new Shape { Width = 100, Height = 30, Type = ShapeType.Rectangle });

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

        }


    }




}