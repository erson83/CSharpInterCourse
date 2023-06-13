using System;

namespace Interface3

{

    public class MyCollection
    {
        private string[] data = new string[10];    // another method to do this, we can skip the ctor portion

        // the special use of "this"
        public string this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }


    }


    public class MyCollection2
    {
        private readonly string[] _data;

        public MyCollection2()
        {
            this._data = new string[5];
        }

        public string this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }

        }


    }
        class Program

    {

        static void Main(string[] args)
        {
            var collection = new MyCollection();
            collection[0] = "Number 1";

            var item = collection[0]; // value is now "Value 1"
            Console.WriteLine(item);
            collection[1] = "Number 2";
            Console.WriteLine(collection[1]);



            var collection2 = new MyCollection2();
            collection2[0] = "Letter A";
            Console.WriteLine(collection2[0]);


        }


    }




}

