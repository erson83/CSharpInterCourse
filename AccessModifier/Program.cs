namespace AccessModifiers

{
    // don't use this get set method. use the properties method instead
    // this is a longer method
    // this is to set some objects private

    class Program

    {



        static void Main(string[] args)
        {
            //A class member declared with private is accessible only from inside the class.
            var person = new Person();
            person.SetBirthdate(new DateTime(1983, 1, 1));
            Console.WriteLine(person.GetBirthdate());

            
            Console.WriteLine(person.CalculateAge(new DateTime(1983, 1, 1)));
        }


    }




}

