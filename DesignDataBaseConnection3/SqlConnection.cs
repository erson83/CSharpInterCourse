using System.Data.Common;

namespace ExDBConnection3

{

        public class SqlConnection : DbConnection
    {
            public SqlConnection(string connectionstring, TimeSpan duration)
            :base(connectionstring, duration)
        {

        }


            public override void Open()
            {
                Console.WriteLine("Opening SQL connection: " + ConnectionString);

            }

            public override void Close()
            {
                Console.WriteLine("Closing SQL connection. TimeTaken : " + GetDuration());
            }

        }
 


}


