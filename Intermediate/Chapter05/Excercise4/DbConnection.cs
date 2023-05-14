namespace Exercise4
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException("You can't open a DbConnection with an empty connection string!");
            }

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}