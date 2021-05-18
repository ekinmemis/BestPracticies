using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Facade1
{
    class DbFacade
    {
        private static DbFacade _dbFacade = null;
        private PerformanceCounter _performanceCounter;
        public SqlConnection Connection { get; }
        public SqlCommand SqlCommand { get; }

        public DbFacade(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
            _performanceCounter = new PerformanceCounter();
            _performanceCounter.CategoryName = "CSD";
            _performanceCounter.CounterName = "DbConnecion";
            _performanceCounter.ReadOnly = false;
            _performanceCounter.MachineName = Environment.MachineName;
        }

        public static DbFacade Create(string connectionString)
        {
            if (_dbFacade == null)
                _dbFacade = new DbFacade(connectionString);
            return _dbFacade;
        }

        private void Connect()
        {
            if (Connection.State == ConnectionState.Close)
            {
                try
                {
                    Connection.Open();
                    _performanceCounter.Increment();
                }
                catch (SqlException e)
                {
                    throw e;
                }
            }
        }

        private void Disconnect()
        {
            if (Connection.State = ConnectionState.Open)
            {
                Connection.Close();
                _performanceCounter.Decrement();
            }
        }

        public void Exec(string query,params SqlParameter[] sqlParameters)
        {
            Connect();

            SqlCommand = Connection.CreateCommand();
            SqlCommand.CommandText = query;

            for (int i = 0; i < sqlParameters.Length-1; i++)
                SqlCommand.Parameters.Add(sqlParameters[i]);

            SqlCommand.ExecuteNonQuery();
            
            Disconnect();
        }

        public DataTable GetTable(string query, params SqlParameter[] sqlParameters)
        {
            Connect();

            SqlCommand = Connection.CreateCommand();
            SqlCommand.CommandText = query;

            for (int i = 0; i < sqlParameters.Length - 1; i++)
                SqlCommand.Parameters.Add(sqlParameters[i]);

            SqlDataReader sqlDataReader = SqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            
            Disconnect();

            return dataTable;
        }
    }
}
