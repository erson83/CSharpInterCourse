using System.Data.Common;

namespace ExDBConnection

{

        public class SqlConnection : DbConnection
    {
            public SqlConnection(string connectionstring)
            :base(connectionstring)
        {

        }


            public override void Open()
            {
                Console.WriteLine("Opening SQL connection: " + ConnectionString);
            }

            public override void Close()
            {
                Console.WriteLine("Closing SQL connection");
            }

        }
 


}


