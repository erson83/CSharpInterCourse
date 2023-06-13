namespace PropertiesSet3
{


    public class Movie
    {
        // declare variables in camel case
        public string Title;
        public string Director;
        private string _rating;

        // intialize
        public Movie(string title, string director, string rating)
        {
            this.Title = title;
            this.Director = director;
            this.Rating = rating; // be careful of the declaration of weight here. cannot use _rating = rating

        }

        // here is where we must use Pascal case
        public string Rating
        {
            get { return _rating; }
            set
            {

                if (value == "PG-13" || value == "RA")
                {
                    _rating = value;
                }
                else
                {
                    _rating = "ERROR!";
                    Console.WriteLine("the rating is nonsense!");
                }

            }

        }


    }

        class Program

        {

            static void Main(string[] args)
            {

            var avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Console.WriteLine(avengers.Rating);

            var shrek = new Movie("Shrek", "Adam Adamson", "DOG");
            Console.WriteLine(shrek.Rating);

        }


        }
    }






