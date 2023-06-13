using System.Data.Common;
using System.Threading.Tasks;

namespace ExDBConnection3

{
    public class Program

    {




        static void Main(string[] args)
        {
            string connectionstring = "sql.100.1.100";
            TimeSpan duration = TimeSpan.Parse("00:00:00");


            var sqlconnection = new SqlConnection(connectionstring, duration);
            sqlconnection.Open();
            sqlconnection.Starttimer();
            sqlconnection.Stoptimer();
            sqlconnection.Close();


            var oracleconnection = new OracleConnection(connectionstring);

            oracleconnection.Open();
            oracleconnection.Starttimer();
            oracleconnection.Stoptimer();
            oracleconnection.Close();



        }


    }




}


