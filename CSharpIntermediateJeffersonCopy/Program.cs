namespace Classes

{

    public class Person
    {
        // Creating a person object from a string - create a string
        //name field stored in class
        public string Name;

        //method uses public void
        public void Introduce(string to)
        {
        Console.WriteLine("Hi {0}, i am {1}",to, Name);

        }

        // static member is only available in a class and not object
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;

        }
}

    class Program

    {

        static void Main(string[] args)
        {

            // person is a newly declared object
            var person = Person.Parse("John");

            //  instance method: when calling object .person.Introduce, we are calling a method
            person.Introduce("Mosh");



        }


    }




}


