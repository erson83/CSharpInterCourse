namespace ExDBCommand



{

    public class DBConnection : DBCommand
    {
        public DBConnection(string connectionstring, string sqlquery, string sqltype)
        : base(connectionstring, sqlquery, sqltype)
        {

        }


        public override void Open()
        {
            if (SqlType == "SQL")
            Console.WriteLine("Opening SQL connection: " + ConnectionString);
            else
            Console.WriteLine("Opening Oracle connection: " + ConnectionString);
        }

        public override void Run()
        {
                Console.WriteLine("Running connection string:  " + SqlQuery);
        }

        public override void Close()
        {
            if (SqlType == "SQL")
                Console.WriteLine("Closing SQL connection.  ");
            else
                Console.WriteLine("Closing Oracle connection.  ");
        }

    }



}
