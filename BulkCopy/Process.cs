using System;
using System.Data;
using System.Data.SqlClient;

namespace BulkCopy
{
    public class Process
    {
        public void LoadFile(string tableName)
        {
            BasicDataStructure dbs = new BasicDataStructure();
            DataTable dt = dbs.BuildTable(tableName);
            DataTable ProductDT = dbs.LoadData(dt);

            var dbConn = DbConnect();

            SqlBulkCopy bcp = new SqlBulkCopy(dbConn);
            bcp.DestinationTableName = "product_wrk";
            bcp.BatchSize = 20;
            bcp.BulkCopyTimeout = 10;

            foreach(DataColumn column in ProductDT.Columns)
            {
                bcp.ColumnMappings.Add(column.ColumnName, 
                                        column.ColumnName);
            }
            bcp.WriteToServer(ProductDT);



            dbConn.Close();
            dbConn.Dispose();
            
        }
        public SqlConnection DbConnect()
        {
            string connectionString = BuildConnectionString();
            if (connectionString == null) return null;

            var dbConn = new SqlConnection();
            dbConn.ConnectionString = connectionString;
            dbConn.Open();

            return (dbConn);
        }

        public string BuildConnectionString()
        {
            System.Text.StringBuilder sConnection =
                    new System.Text.StringBuilder();

            sConnection.Append("Data Source=SQL_SERVER_NAME");
            sConnection.Append(";Database=data_base_name");
            sConnection.Append(";User Id=software");
            sConnection.Append(";Password=nuggets");
            sConnection.Append(";Connection Timeout=15;Connection Lifetime=0;Min Pool Size=0;");
            sConnection.Append(";Max Pool Size=100;Pooling=true;");

            return sConnection.ToString();
        }
    }
}
