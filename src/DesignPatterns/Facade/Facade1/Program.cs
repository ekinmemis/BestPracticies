using System;

namespace Facade1
{
    class Program
    {
        private DbFacade db = new DbFacade(connectionString: "");
        static void Main(string[] args)
        {
            db.Exec("select * from table1 where id = @id", new SqlParameter()
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.int,
                Value = 1
            });
        }
    }
}
