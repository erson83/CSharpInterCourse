namespace AccessModifiers

{
    class Person
    {

        // fields as private
        // private should start with _ and camel case
        // getter/sett as public

        private DateTime _birthdate;
        private int Age;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;

        }


        public DateTime GetBirthdate()
        {

            return _birthdate;
        }

        public int CalculateAge(DateTime birthdate)
        {
            Age = DateTime.Today.Year - _birthdate.Year;
            return Age;
        }


    }




}

