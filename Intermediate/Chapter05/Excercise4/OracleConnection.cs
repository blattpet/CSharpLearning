namespace Exercise4
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string ConnectionString) 
            : base(ConnectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connection to Oracle Database is open.");

        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection to Oracle Database is closed.");
        }
    }
}