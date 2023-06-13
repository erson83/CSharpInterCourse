namespace ConstructorsPart2

{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        private readonly int _serialNo;
        private readonly string _modelType;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being intialized. Base class is always run first");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being privately intialized. Base class is always run first 1st line {0}", registrationNumber);

        }

        public Vehicle(string registrationNumber,int serialNo)
            :this(registrationNumber)
        {
            _serialNo = serialNo;
            Console.WriteLine("Vehicle is being privately intialized. Base class is always run first 2nd line {0}", serialNo);

        }

        public Vehicle(string registrationNumber, int serialNo, string modelType)
    : this(registrationNumber, serialNo)
        {
            _modelType = modelType;
            Console.WriteLine("Vehicle is being privately intialized. Base class is always run first 3nd line {0}", modelType);

        }

    }




}


