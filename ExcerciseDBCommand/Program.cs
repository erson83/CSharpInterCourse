namespace ExDBCommand

{


    public class Program


    {

        static void Main(string[] args)
        {

           var connectionstring = "120.11.11.11";
           var sqlquery = "Select * from XXXX";
            // use SQL to select SQL connection. Use Oracle to select Oracle connection.
           var sqltype = "SQL";

            var dbcommand = new DBCommand(connectionstring,sqlquery,sqltype);
            dbcommand.Execute();

        }


    }




}


