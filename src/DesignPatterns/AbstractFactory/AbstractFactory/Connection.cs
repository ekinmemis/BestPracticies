namespace AbstractFactory
{
    abstract class Connection
    {
        public abstract void Connect();
        protected string connectionString;
        public abstract string ConnectionString { get; set; }
    }
}
