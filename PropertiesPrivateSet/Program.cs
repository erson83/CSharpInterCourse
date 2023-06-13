namespace PropertiesPrivateSet
{

    class Program

    {

        static void Main(string[] args)
        {

            var person = new Person(new DateTime(1982, 1, 1));
            // we cannot use the two sentence below when using private set
            // we need to pass the person.Birthdate inside the brackets new Person()

            // var person = new Person();
            // person.Birthdate = new DateTime(1982, 1, 1);
            Console.WriteLine("Age:" + person.Age);



        }


    }




}
