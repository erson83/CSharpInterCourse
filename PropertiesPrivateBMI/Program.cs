namespace PropertiesPrivateBMI
{

    public class AnotherPerson
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        // do not have to intiate

        public double BMI
        {
            get
            {
                var bmi = Weight / (Height * Height);

                return bmi;


            }


        }
    }



    class Program

    {

        static void Main(string[] args)
        {

         var person = new Person(62.3,130);
         Console.WriteLine("BMI:" + person.BMI);


            // if i do not want to bother about the order of passing in arguement
            // we can use the shortcut below

         var person2 = new AnotherPerson { Weight = 71.2, Height = 165 };
         Console.WriteLine("BMI:" + person2.BMI);

        }


    }




}
