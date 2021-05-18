using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;

namespace DMS
{
    public class DocumentSystem : MarshalByRefObject, IDocumentSystem
    {
        private string _connectionString = @"data source=.;initial catalog=DocMS;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";


        public void AddDocument(string path)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "addDocument";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@path", path);
            command.Parameters.AddWithValue("@extension", Path.GetExtension(path));
            command.Parameters.AddWithValue("@username", Environment.UserName);
            command.ExecuteNonQuery();

            connection.Close();
        }

        public string GetDocument()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Documents", _connectionString);
            DataTable table1 = new DataTable();
            adp.Fill(table1);

            List<DocumentEntity> docs = new List<DocumentEntity>(table1.Rows.Count);

            DataTableReader tableReader = new DataTableReader(table1);

            while (tableReader.Read())
            {
                docs.Add(new DocumentEntity()
                {
                    Id = tableReader.GetInt32(0),
                    Path = tableReader.GetString(1),
                    Extension = tableReader.GetString(2),
                    AddedDate = tableReader.GetDateTime(3)
                });
            }

            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Serialize(docs);
        }
    }
}
