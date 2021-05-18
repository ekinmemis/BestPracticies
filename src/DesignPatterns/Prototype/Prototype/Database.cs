using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Database : ICloneable
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private ArrayList _tables = new ArrayList();

        public Database()
        {
            _name = "Model";
            string[] system_tables = { "system_user", "system_indexes", "system_files" };
            _tables.AddRange(system_tables);
        }

        public void AddTable(string tableName)
        {
            _tables.Add(tableName);
        }

        public void RemoveTable(string tableName)
        {
            _tables.Remove(tableName);
        }

        public void TableList()
        {
            for (int i = 0; i <= _tables.Count - 1; i++)
                Console.WriteLine(_tables[i]);
        }

        public object Clone()
        {
            return new Database();
        }
    }
}
