namespace InheritancePart2

{

    public class Property // parent class
    {
        // declare varibale



        // intialize


        public void Copy()
        {
            Console.WriteLine("Copying....");
        }

        public void Paste()
        {
            Console.WriteLine("Pasting....");
        }

        public void Validate()
        {
            Console.WriteLine("Validating....");
        }

    }


    public class Alignment : Property   //child class
    {

        public string Align;

        public Alignment(string align)
        {
            this.Align = align;
        }

        public void AlignText()
        {
            Console.WriteLine("Aligning text to {0}",Align);
            Validate();
        }

    }


    public class Text : Property   // child class
    {

        // declare variable

        public int FontSize;
        public string FontType;

        // intialize variable

        public Text(int fontSize)
        {
            this.FontSize = fontSize;

        }

        public Text(int fontSize, string fontType)
            :this(fontSize)
        {
            if (string.IsNullOrEmpty(fontType))
            {
                throw new SystemException("Font type is empty");
            }
            this.FontType = fontType;

        }

        public void FormatText()
        {

            Console.WriteLine("Formating text to Font size {0} and Font Type {1} ",FontSize, FontType);
        }



    }


    class Program

    {

        static void Main(string[] args)
        {
            var text = new Text(1,"Arial");
            text.FormatText();

            var alignment = new Alignment("centre");
            alignment.AlignText();

        }


    }




}

