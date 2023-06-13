using System.Data.Common;
using System.Threading.Tasks;

namespace ExDBConnection2

{
    public class Program

    {




        static void Main(string[] args)
        {
            string connectionstring = "sql.100.1.100";



            var sqlconnection = new SqlConnection(connectionstring);
            sqlconnection.Open();
            sqlconnection.Starttimer();
            sqlconnection.Stoptimer();
            sqlconnection.Close();

            var oracleconnection = new OracleConnection(connectionstring);

            oracleconnection.Open();
            oracleconnection.Starttimer();
            oracleconnection.Stoptimer();
            oracleconnection.Close();


            Console.WriteLine("Total time taken: " + oracleconnection.GetDuration());

        }


    }




}


