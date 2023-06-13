namespace ExDBConnection2
{
    public class OracleConnection : DbConnection
    {

        public OracleConnection(string connectionstring)
        : base(connectionstring)
        {

        }


        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection: " + ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection.");
        }
    }
}