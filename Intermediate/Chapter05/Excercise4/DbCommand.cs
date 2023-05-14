namespace Exercise4
{
    partial class Program
    {
        public class DbCommand
        {
            public DbConnection DbConnection { get; private set; }
            public string DbInstruction { get; private set; }

            public DbCommand(DbConnection dbConnection, string command)
            {
                if (dbConnection == null || string.IsNullOrWhiteSpace(command))
                {
                    throw new ArgumentNullException("You can't execute a DbCommand without a DbConnection or a command!");
                }
                DbConnection = dbConnection;
                DbInstruction = command;
            }

            public void Execute()
            {
                DbConnection.OpenConnection();
                Console.WriteLine("Run command: {0}", DbInstruction);
                DbConnection.CloseConnection();
            }
        }
    }
}