using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPool
{
    public class PoolManager
    {
        private const int POOL_SIZE = 10;
        protected static PoolManager poolManager;
        private Dictionary<string, List<ConnectionContext>> pools;

        protected PoolManager()
        {
            pools = new Dictionary<string, List<ConnectionContext>>(POOL_SIZE);
        }

        public static PoolManager CreatePool()
        {
            if (poolManager == null)
                poolManager = new PoolManager();
            return poolManager;
        }

        public ConnectionContext TakeConnection(string key)
        {   //eğer böyle bir anahtar değer havuzda varsa
            if (pools.ContainsKey(key))
            {   //havuzdan bul
                List<ConnectionContext> objects = (List<ConnectionContext>)pools[key];

                //aktifse geriye dön
                foreach (var item in objects)
                    if (item.IsActive)
                        return item;
            }
            else
            {   //eğer böyle bir anahtar değer havuzda yoksa
                List<ConnectionContext> newPool = new List<ConnectionContext>(POOL_SIZE);
                for (int i = 0; i < POOL_SIZE - 1; i++)
                    newPool.Add(new ConnectionContext());
                //havuza ekle yeni havuzu
                pools.Add(key, newPool);

                ConnectionContext connectionContext = newPool[0];
                connectionContext.IsActive = true;
                return connectionContext;
            }
            return null;
        }

        public void RelaseConnection(ConnectionContext connectionContext)
        {
            connectionContext.IsActive = false;
        }
    }
}
