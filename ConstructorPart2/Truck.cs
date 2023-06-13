namespace ConstructorsPart2

{
    public class Truck : Vehicle
    {
        public Truck(string truckregistrationNumber)
            : base(truckregistrationNumber)
        {
            Console.WriteLine("Truck is being intialized. child class {0}", truckregistrationNumber);
        }

    }




}


