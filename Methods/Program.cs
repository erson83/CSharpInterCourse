using System.Security.Cryptography.X509Certificates;

namespace Methods

{

    class Program

    {

        static void Main(string[] args)
        {

            // two alternative method to handle exception
            // one way is use try catch

            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("conversion failed");
            }

            // another way is to use tryparse

            int number;
            //using try parse does not throw an exception, only boolean
            // the out is a out method
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion failed");


        }

        static void Calculate()
        {

            var calculator = new Calculator();
            //passing params mean can pass any number of parameters into method
            //passing in 3 variables
            Console.WriteLine("3 vriables: " + calculator.Add(1, 2, 3));
            // passing in 6 variables
            Console.WriteLine("6 variables: " + calculator.Add(1, 2, 3, 4, 5, 6));
            // not necessary to declare new int [] array when using params
            Console.WriteLine("2 variables using new integer array but not necessary: "
                + calculator.Add(new int[] {1,2}));

        }

        static void Multiply()
        {

            var multiplyCalculator = new MultiplyCalculator();
            //passing params mean can pass any number of parameters into method
            //passing in 3 variables
            Console.WriteLine("3 vriables: " + multiplyCalculator.Multiply(1, 2, 3));
            // passing in 6 variables
            Console.WriteLine("6 variables: " + multiplyCalculator.Multiply(1, 2, 3, 4, 5, 6));
            // not necessary to declare new int [] array when using params

        }


        static void UsePoints()
        {

            try
            {
                var point = new Point(0,0);
                Console.WriteLine("point is at {0} and {1}", point.X, point.Y);
                point.Move(40, 60);
                Console.WriteLine("point is moved to {0} and {1}", point.X, point.Y);

                // using overload method
                point.Move(100, 150);
                Console.WriteLine("point is moved again to {0} and {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurs");
            }



        }

        
    }




}