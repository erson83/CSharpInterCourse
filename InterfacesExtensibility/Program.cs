using System;
using System.Threading.Channels;

namespace Extensibility
{

    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            using (var streamWriter = new StreamWriter(_path,true))
            {
                streamWriter.WriteLine("ERROR: " + message);
            }
        }

        public void LogInfo(string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine("INFO: " + message);
            }
        }
    }

    public class ConsoleLogger : ILogger  // right click and refactor to quickly bring up 
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }


    public interface ILogger
    {
    void LogError(string message);
    void LogInfo(string message);
    }

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo(String.Format("Migrating started at {0}", DateTime.Now));
            // Console.WriteLine("Migrating started at {0}", DateTime.Now);
            _logger.LogInfo(String.Format("Migrating ended at {0}", DateTime.Now));
            // Console.WriteLine("Migrating ended at {0}", DateTime.Now);


        }
    }

    class Program

    {

        //        If a class is dependent on an interface, we can supply a different implementation of
        //that interface at runtime.This way, the behaviour of the application changes without
        //any impact on that class.

        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            var dbMigrator2 = new DbMigrator(new FileLogger("/Users/jeffersonong/Projects/CsharpIntermediate/InterfacesExtensibility/LogFile.txt"));
            dbMigrator2.Migrate();
        }


    }
}

