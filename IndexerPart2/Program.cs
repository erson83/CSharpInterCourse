using System.Net;

namespace IndexPart2


{

    public class Config
    {
        // declare vairbale
        private readonly Dictionary<string,string> _config;

        //intialize variable

        public Config()
        {
            this._config = new Dictionary<string, string>();

        }

        public string this[string key]
        {
            get { return _config[key]; }
            set { _config[key] = value; }

        }


    }

    class Program

    {

        static void Main(string[] args)
        {
            var config = new Config();
            config["filepath_sharefolder"] = "c:\\sharedfolder\\Master.xlsx";
            config["filepath_Datafolder"] = "c:\\data\\Master.xlsx";

            Console.WriteLine(config["filepath_sharefolder"]);
            Console.WriteLine(config["filepath_Datafolder"]);



        }


    }




}

