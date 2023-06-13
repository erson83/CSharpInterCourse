namespace PropertiesSet

{
    public class Person
    {
        public DateTime Birthdate { get; set; }  // do not have to use ctor

        private int _calculateAge;


        public int CalculateAge
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;

                return years;
            }

            set { }

        }

        public Person()   // empty contruct , can be deleted, no difference in code
        {
        }
    }
}

