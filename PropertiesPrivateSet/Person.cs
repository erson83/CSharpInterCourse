namespace PropertiesPrivateSet
{
    public class Person
    {
        // 1. all get set should be placed on top first

        // set accesor is set to private
        // can type prop tab
        public DateTime Birthdate { get; private set; }


        //2. followed by the constructor
        // when we use private set, we need to create a constructor
        // this is to intilalize the Birthday
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }



        //3. followed by method
        public int Age

        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;

                return years;


            }


        }




    }




}
