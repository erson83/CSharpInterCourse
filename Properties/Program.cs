﻿namespace PropertiesSet
{ 

    class Program

    {

        static void Main(string[] args)
        {


            // var person = new Person(new DateTime(1982, 1, 1));
            var person = new Person();
            person.Birthdate = new DateTime(1982, 1, 1);
            Console.WriteLine("Age:" + person.CalculateAge);



        }


    }




}

