namespace ConstructorsPart2

{
    public class Car : Vehicle
    {
        public Car(string carregistrationNumber)
            :base(carregistrationNumber)
        {
        Console.WriteLine("Car is being intialized. child class {0}", carregistrationNumber);
        }

        public Car(string carregistrationNumber, int serialNo)
             : base(carregistrationNumber, serialNo)
        {
            Console.WriteLine("Car is being intialized.child class {0}", carregistrationNumber);
            Console.WriteLine("Car is being intialized.child class {0}", serialNo);
        }


    }




}


