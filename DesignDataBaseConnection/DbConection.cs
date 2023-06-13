namespace ExDBConnection

{

    public abstract class DbConnection
     {

        // declare variables

        public string ConnectionString;
        public TimeSpan Timeout; 

        // initialize variables

        public DbConnection(string connectionstring)
        {
            if (string.IsNullOrWhiteSpace(connectionstring))
                throw new ArgumentException("Connection string cannot be null or empty");
            this.ConnectionString = connectionstring;

        }

        public DbConnection(string connectionstring, TimeSpan timeout)
            :this(connectionstring)
        {
            this.Timeout = timeout;
        }


        // declaring methods using abstract mode

        public abstract void Open();
        public abstract void Close();


     }

}


