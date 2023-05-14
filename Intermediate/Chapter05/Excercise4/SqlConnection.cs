namespace Exercise4
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string ConnectionString) 
            : base(ConnectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connection to SQL Server is open.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection to SQL Server is closed.");
        }
    }
}