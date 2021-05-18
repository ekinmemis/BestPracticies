namespace AbstractFactory
{
    abstract class DBFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
