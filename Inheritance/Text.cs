namespace Inheritance

{
    public class Text : PresentationObject    // text is child class

    // text is an annotation to represent Inheritance
    // child class
    // child class will inheritate all from parent class

    {
        public int FontSize { get; set; }
        public string FontName { get; set; }


        public Text(string fontname)
        {
            this.FontName = fontname;

        }

        public Text(string fontname, int fontsize)
            :this(fontname)
        {
            this.FontSize = fontsize;
        }


        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link " + url);
            Console.WriteLine("Fontsize is: " + FontSize);
        }


    }




}

