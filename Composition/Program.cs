namespace Composition

{


    // create logger class to be reused in two other classes - Installer and DBMigrator

    // - A kind of relationship that allows one class to contain another.
    // - Referred to as Has-A relationship: A Car has an Engine "1
    // - Benefits: Code re-use, flexibility and a means to loose-coupling


    class Program

    {

        static void Main(string[] args)
        {

            // 1. pass in logger object using new logger
            // call upon child class
            var dbMigrator = new DbMigrator(new Logger());

            // 2. pass in logger after declaring logObj variable
            // declare new parent class
            // call upon child class
            var logObj = new Logger();
            var installer = new Installer(logObj);


            dbMigrator.Migrate();
            dbMigrator.MigratePartial();
            installer.Install();





            


        }


    }




}