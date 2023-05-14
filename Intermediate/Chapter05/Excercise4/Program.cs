namespace Exercise4
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Run Exercise 4 ###");
            var sqlConnection = new SqlConnection("Hello World");
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            var oracleConnection = new OracleConnection("Hello World");
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();


            Console.WriteLine("\n### Run Exercise 5 ###");
            var dbCommandSql = new DbCommand(new SqlConnection("Hello World"), "SQL do something");
            dbCommandSql.Execute();

            var dbCommandOracle = new DbCommand(new OracleConnection("Hello World"), "Oracle do something");
            dbCommandOracle.Execute();
        }
    }
}