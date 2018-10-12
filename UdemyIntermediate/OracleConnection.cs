using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIntermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            base.CheckOpenConnection();
            Console.WriteLine("Successfully closed Oracle connection.");
            base.connectionOpened = false;
        }

        public override void OpenConnection()
        {
            base.AttemptConnection();
            Console.WriteLine("Succesfully opened Oracle connection."); ;
        }
    }
}
