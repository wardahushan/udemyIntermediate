using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIntermediate
{
    public class DbCommand
    {
        private readonly DbConnection dbConnection;
        private readonly string instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (string.IsNullOrWhiteSpace(instruction))
            {
                throw new NotSupportedException("Failed: DB command must be provided with an instruction.");
            }

            this.dbConnection = dbConnection;
            this.instruction = instruction;
        }

        public void Execute()
        {
            dbConnection.OpenConnection();
            Console.WriteLine("Running the instruction to the database... ");
            dbConnection.CloseConnection();
        }
    }
}
