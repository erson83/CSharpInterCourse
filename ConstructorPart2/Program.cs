using System;

namespace ConstructorsPart2

{
    // inheritance 


    public class Motorcycle : Vehicle
    {
        public Motorcycle(string registrationNumber, int serialNo, string modelType)
            :base(registrationNumber,serialNo,modelType)
        {
            Console.WriteLine("Motor is being intialized.child class {0}", registrationNumber);
            Console.WriteLine("Motor is being intialized.child class {0}", serialNo);
            Console.WriteLine("Motor is being intialized.child class {0}", modelType);
        }
    }


    class Program

    {

        static void Main(string[] args)
        {
            string licenseNoCar = "SG1234E";
            var car = new Car(licenseNoCar, 123);

            string licenseNoTruck = "TRU1234";
            var truck = new Truck(licenseNoTruck);


            var motorcycle = new Motorcycle("MOTOR1",1234,"C5");


        }


    }




}


