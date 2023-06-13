namespace Inheritance

{
    public class PresentationObject   // parent class

        // parent class
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
            Console.WriteLine("Width: " + Width);
        }

        public void Duplicate()
        {

            Console.WriteLine("Object was duplicated");
        }


    }




}

