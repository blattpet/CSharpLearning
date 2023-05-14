namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("Hello World");
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            var oracleConnection = new OracleConnection("Hello World");
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();
        }
    }
}