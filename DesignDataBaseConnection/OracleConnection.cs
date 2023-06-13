namespace ExDBConnection
{
    public class OracleConnection : DbConnection
    {

        public OracleConnection(string connectionstring, TimeSpan timeout)
        : base(connectionstring, timeout)
        {

        }


        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection: " + ConnectionString + Environment.NewLine + Timeout);
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection");
        }
    }
}