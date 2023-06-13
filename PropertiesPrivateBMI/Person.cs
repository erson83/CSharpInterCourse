namespace PropertiesPrivateBMI
{
    public class Person
    {
        public double Weight { get; private set; }

        public double Height { get; private set; }


        public Person(double weight, double height)
        {
            this.Weight = weight;
            this.Height = height;
        }


        public double BMI
        {
            get
            {
                var bmi = Weight / (Height * Height);

                return bmi;


            }


        }
    }




}
