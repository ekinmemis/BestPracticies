namespace AbstractFactory
{
    class FactoryUtil
    {
        public static DBFactory GetFactory(string dbName)
        {
            if (dbName == "Sql")
                return new SqlFactory();

            if (dbName == "Oracle")
                return new OracleFactory();

            return null;
        }


    }
}
