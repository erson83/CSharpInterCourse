namespace Interface2

{

    // An interface is simply a declaration of the capabilities (or services) that a class should
    // provide.
    public interface IResizable
    {

        int CurrentWidth { get; }
        int CurrentHeight { get; }

        void Resize(int width, int height);
    }

    public class Rectangle : IResizable
    {
        public int CurrentWidth { get; private set; }
        public int CurrentHeight { get; private set; }

        public void Resize(int width, int height)
        {
            CurrentWidth = width;
            CurrentHeight = height;
        }
    }





    // Interfaces allow you to define common behavior that multiple classes can implement, providing a way to
    // establish a common understanding of how objects of those classes should be used. They promote code reusability,
    // maintainability, and enable polymorphism.

    //An interface can only declare methods and properties, but not fields(because fields
    //are about implementation detail).
    //    - An interface can only declare methods and properties, but not fields(because fields
    //are about implementation detail).
    //- Members of an interface do not have access modifiers.

    class Program

    {

        static void Main(string[] args)
        {

            IResizable resizable = new Rectangle();
            resizable.Resize(10, 5);
            Console.WriteLine(resizable.CurrentWidth); // Output: 10
            Console.WriteLine(resizable.CurrentHeight); // Output: 5


        }


    }




}

