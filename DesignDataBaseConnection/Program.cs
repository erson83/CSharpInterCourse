using System.Data.Common;

namespace ExDBConnection

{
    public class Program

    {




        static void Main(string[] args)
        {
            string connectionstring = "sql.100.1.100";
            TimeSpan timeout = TimeSpan.Parse("00:00:02");

            var sqlconnection = new SqlConnection(connectionstring);
            sqlconnection.Open();
            sqlconnection.Close();

            var oracleconnection = new OracleConnection(connectionstring,timeout);
            oracleconnection.Open();
            oracleconnection.Close();


        }


    }




}


