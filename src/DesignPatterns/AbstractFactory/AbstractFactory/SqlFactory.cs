namespace AbstractFactory
{
    class SqlFactory : DBFactory
    {
        public override Command CreateCommand()
        {
            return new SqlCommand();
        }

        public override Connection CreateConnection()
        {
            return new SqlConnection();
        }
    }
}
