using System.Runtime.Intrinsics.X86;

namespace Inheritance

{

    class Program

    {

        //- A kind of relationship between two classes that allows one to inherit code from the
        // other.
        //  - Referred to as Is-A relationship: A Car is a Vehicle
        //  - Benefits: code re-use and polymorphic behaviour.

        static void Main(string[] args)
        {

            var text = new Text(string.Empty);
            // using text will fetch the child class
            text.FontSize = 10;
            text.AddHyperlink("www.google.com");

            // using text will fetch the parent class
            text.Width = 100;
            text.Copy();

            var alignment = new Alignment();
            alignment.AlignCenter();


        }


    }




}

