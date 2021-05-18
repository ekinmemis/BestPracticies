using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPool
{
    public class Connection
    {
        private ConnectionContext _connectionContext;
        private PoolManager _poolManager;

        private string _connectionString;

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public Connection(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public void Open()//havuzdan çekelim
        {
            _poolManager = PoolManager.CreatePool();
            
            _connectionContext = _poolManager.TakeConnection(_connectionString);

            if (_connectionContext != null)
                _connectionContext.Open();
            else
                Console.WriteLine("Havuzda uygun nesne yok");
        }

        public void Close()
        {
            _poolManager.RelaseConnection(_connectionContext);
            _connectionContext.Close();
        }

        public void Execute(string query)
        {
            _connectionContext.Execute(query);
        }
    }
}
