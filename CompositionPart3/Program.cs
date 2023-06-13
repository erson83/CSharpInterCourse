namespace Composition3

{

    public class Car // parent class
    {
        // declare variable
        // only need to declare private readonly
        private readonly Engine _engine;
        private readonly Transmission _transmission;
        private readonly Speed _speed;

        public Car(Engine engine, Transmission transmission,Speed speed) // remember to pass here!
        {
            this._engine = engine;
            this._transmission = transmission;
            this._speed = speed;

        }

        public void Start()
        {

            // need to declare a here like in Main but using sub class
            _engine.Start();
            _speed.Accelerating(); // able to call child class here

        }

        public void Stop()
        {
            // need to declare a here like in Main but using sub class
            _speed.Decelerating(); // able to call child class here
            _engine.Stop();
 
        }


    }

    public class Engine // child class 1
    {

        // under engine class, purely methods are inside only
        public void Start()
        {
            Console.WriteLine("Starting engine....");
            
        }

        public void Stop()
        {

            Console.WriteLine("Engine stopping...");
        }
    }

    public class Transmission // child class 2
    {
        public void ShiftToDrive()
        {
            Console.WriteLine("Shift to drive....");
            
        }

        public void ShiftToPark()
        {
            Console.WriteLine("Shift to part....");
        }

    }

    public class Speed //child class 3
    {
        public void Accelerating()
        {
            Console.WriteLine("Accelerating....");

        }

        public void Decelerating()
        {
            Console.WriteLine("Decelerating...");
         }
    }


    class Program

    {

        static void Main(string[] args)
        {
            var engine = new Engine();
            var transmission = new Transmission();
            var speed = new Speed();
            var car = new Car(engine, transmission, speed);
            // alternatively, can use one line
            // var car = new Var(new Engine(), new Transmission());
            car.Start();
            
            transmission.ShiftToDrive(); //able to call the child class here
            transmission.ShiftToPark();

            car.Stop();


        }


    }




}