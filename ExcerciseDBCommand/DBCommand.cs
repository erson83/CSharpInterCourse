namespace ExDBCommand

{
    public class DBCommand

    {
        public string ConnectionString;
        public string SqlQuery;
        public string SqlType;

        public DBCommand(string connectionstring)
        {
            if (string.IsNullOrWhiteSpace(connectionstring))
                throw new ArgumentException("Connection string cannot be null or empty");
            this.ConnectionString = connectionstring;

        }

        public DBCommand(string connectionstring, string sqlquery)
            : this(connectionstring)
        {
            if (string.IsNullOrWhiteSpace(sqlquery))
                throw new ArgumentException("sqlquery string cannot be null or empty");
            this.SqlQuery = sqlquery;

        }

        public DBCommand(string connectionstring, string sqlquery, string sqltype)
    : this(connectionstring,sqlquery)
        {
            if (string.IsNullOrWhiteSpace(sqltype))
                throw new ArgumentException("sqltype string cannot be null or empty");
            this.SqlType = sqltype;

        }



        public virtual void Open()
        {

        }

        public virtual void Run()
        {

        }

        public virtual void Close()
        {

        }

        public virtual void Execute()
        {
            var dbconnection = new DBConnection(ConnectionString, SqlQuery, SqlType);
            dbconnection.Open();
            dbconnection.Run();
            dbconnection.Close();
        }

    }


}


