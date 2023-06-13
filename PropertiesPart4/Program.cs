// using System;

public class Rectangle
{
    private double _width;
    private double _height;

    public Rectangle(double width,double height)
    {
        this.Width = width;
        this.Height = height;
    }



    public double Width
    {
        get { return _width; }
        set {
            if (value <= 0.0)
            {
                throw new SystemException("Width is zero or negative");
            }
            else
            _width = value; }

        // set { _width = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Width must be positive."); }
    }

    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
            {
                throw new SystemException("Height is zero or negative");
            }
            else
                _height = value;
        }
    }

    public double Area(double _width, double _height)
    {
        return _width * _height;
    }

}

class Program
{
    static void Main(string[] args)
    {
        var rectangle = new Rectangle(3,10);
        //rectangle.Width = 0;
        //rectangle.Height = 10.0;

        Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}, Area: {rectangle.Area(3,10)}");
    }
}
