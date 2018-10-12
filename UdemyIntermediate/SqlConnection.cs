using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            base.CheckOpenConnection(); 
            Console.WriteLine("Succesfully closed Sql Server connection.");
            base.connectionOpened = false;
        }

        public override void OpenConnection()
        {
            base.AttemptConnection();
            Console.WriteLine("Succesfully opened Sql Server connection."); ;
        }
    }
}
