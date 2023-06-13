namespace Index


{
    // Indexer is a special kind of property that allows accessing elements of a list by an
    // index.
    // If a class has the semantics of a list, or collection, we can define an indexer property
    // for it.This way it’s easier to get or set items in the collection


    public class HttpCookie
    {
        //1 . declare variables
        private readonly Dictionary<string, string> _dictionary;
        // can improve the code - this can set the expiry date of the dictionary

        //2. intialize variables
        public HttpCookie()
        {

            _dictionary = new Dictionary<string, string>();   // when using indexer, the intializing is different

        }
        //3. get set method
        // indexer does not have a name, we use 'this' keyword
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }

        }



    }

    class Program

    {

        static void Main(string[] args)
        {

            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
            cookie["salutation"] = "Dr";
            Console.WriteLine(cookie["salutation"]);
        }


    }




}

