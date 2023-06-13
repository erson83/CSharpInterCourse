namespace Composition

{
    // creating a common class to be used in Installer and DBMigrator aka Parent class
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }


}