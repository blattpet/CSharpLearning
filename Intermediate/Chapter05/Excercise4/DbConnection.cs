namespace Exercise4
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }

        public DbConnection(string ConnectionString)
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new ArgumentNullException("You can't open a DbConnection with an empty connection string!");
            }

            this.ConnectionString = ConnectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}