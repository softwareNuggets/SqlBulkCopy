using System;
using System.Data;


namespace BulkCopy
{
    public class BasicDataStructure
    {
        public DataTable BuildTable(string tableName)
        {
            DataTable newProducts = new DataTable(tableName);
            AddColumnsToDataTable(newProducts);

            DataColumn[] keys = new DataColumn[1];
            keys[0] = newProducts.Columns[0];
            newProducts.PrimaryKey = keys;

            return (newProducts);
        }

        private void AddColumnsToDataTable(DataTable newProducts)
        {
            DataColumn productId = new DataColumn();
            productId.ColumnName = "productId";
            productId.DataType = System.Type.GetType("System.Int32");
            productId.AllowDBNull = false;
            productId.Unique = true;
            newProducts.Columns.Add(productId);

            DataColumn c2 = new DataColumn();
            c2.ColumnName = "product_short_desc";
            c2.DataType = System.Type.GetType("System.String");
            c2.AllowDBNull = false;
            c2.MaxLength = 64;
            newProducts.Columns.Add(c2);

            DataColumn c3 = new DataColumn();
            c3.ColumnName = "product_upc";
            c3.DataType = System.Type.GetType("System.String");
            c3.AllowDBNull = false;
            c3.MaxLength = 20;
            newProducts.Columns.Add(c3);

            
        }

        public DataTable LoadData(DataTable dt)
        {
            DataRow dataRow = dt.NewRow();
            dataRow["productId"] = 211;
            dataRow["product_short_desc"] = "10 mm Anti static bubble";
            dataRow["product_upc"] = "000-20221031";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 212;
            dataRow["product_short_desc"] = "11 mm Anti static bubble";
            dataRow["product_upc"] = "001-20221032";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 213;
            dataRow["product_short_desc"] = "11 mm Anti static bubble";
            dataRow["product_upc"] = "002-20221033";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 214;
            dataRow["product_short_desc"] = "13 mm Anti static bubble";
            dataRow["product_upc"] = "003-20221034";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 215;
            dataRow["product_short_desc"] = "14 mm Anti static bubble";
            dataRow["product_upc"] = "004-20221035";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 216;
            dataRow["product_short_desc"] = "15 mm Anti static bubble";
            dataRow["product_upc"] = "000-20221036";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 217;
            dataRow["product_short_desc"] = "17 mm Anti static bubble";
            dataRow["product_upc"] = "000-20221037";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 218;
            dataRow["product_short_desc"] = "18 mm Anti static bubble";
            dataRow["product_upc"] = "000-20221038";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 219;
            dataRow["product_short_desc"] = "19 mm Anti static bubble";
            dataRow["product_upc"] = "000-20221039";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 220;
            dataRow["product_short_desc"] = "209 mm Anti static bubble";
            dataRow["product_upc"] = "000-20221040";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 221;
            dataRow["product_short_desc"] = "210 mm Anti static bubble";
            dataRow["product_upc"] = "000-20221041";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 1211;
            dataRow["product_short_desc"] = "10 mm Anti static bubble";
            dataRow["product_upc"] = "1000-20221031";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 1212;
            dataRow["product_short_desc"] = "11 mm Anti static bubble";
            dataRow["product_upc"] = "1001-20221032";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 1213;
            dataRow["product_short_desc"] = "11 mm Anti static bubble";
            dataRow["product_upc"] = "1002-20221033";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 1214;
            dataRow["product_short_desc"] = "13 mm Anti static bubble";
            dataRow["product_upc"] = "1003-20221034";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 1215;
            dataRow["product_short_desc"] = "14 mm Anti static bubble";
            dataRow["product_upc"] = "1004-20221035";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 1216;
            dataRow["product_short_desc"] = "15 mm Anti static bubble";
            dataRow["product_upc"] = "1000-20221036";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 1217;
            dataRow["product_short_desc"] = "17 mm Anti static bubble";
            dataRow["product_upc"] = "1000-20221037";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 1218;
            dataRow["product_short_desc"] = "18 mm Anti static bubble";
            dataRow["product_upc"] = "1000-20221038";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 1219;
            dataRow["product_short_desc"] = "19 mm Anti static bubble";
            dataRow["product_upc"] = "1000-20221039";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 1220;
            dataRow["product_short_desc"] = "209 mm Anti static bubble";
            dataRow["product_upc"] = "1000-20221040";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 1221;
            dataRow["product_short_desc"] = "210 mm Anti static bubble";
            dataRow["product_upc"] = "1000-20221041";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 2211;
            dataRow["product_short_desc"] = "10 mm Anti static bubble";
            dataRow["product_upc"] = "2000-20221031";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 2212;
            dataRow["product_short_desc"] = "11 mm Anti static bubble";
            dataRow["product_upc"] = "2001-20221032";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 2213;
            dataRow["product_short_desc"] = "11 mm Anti static bubble";
            dataRow["product_upc"] = "2002-20221033";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 2214;
            dataRow["product_short_desc"] = "13 mm Anti static bubble";
            dataRow["product_upc"] = "2003-20221034";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 2215;
            dataRow["product_short_desc"] = "14 mm Anti static bubble";
            dataRow["product_upc"] = "2004-20221035";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 2216;
            dataRow["product_short_desc"] = "15 mm Anti static bubble";
            dataRow["product_upc"] = "2000-20221036";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 2217;
            dataRow["product_short_desc"] = "17 mm Anti static bubble";
            dataRow["product_upc"] = "2000-20221037";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 2218;
            dataRow["product_short_desc"] = "18 mm Anti static bubble";
            dataRow["product_upc"] = "2000-20221038";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 2219;
            dataRow["product_short_desc"] = "19 mm Anti static bubble";
            dataRow["product_upc"] = "2000-20221039";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 2220;
            dataRow["product_short_desc"] = "209 mm Anti static bubble";
            dataRow["product_upc"] = "2000-20221040";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 2221;
            dataRow["product_short_desc"] = "210 mm Anti static bubble";
            dataRow["product_upc"] = "2000-20221041";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 3211;
            dataRow["product_short_desc"] = "10 mm Anti static bubble";
            dataRow["product_upc"] = "3000-20221031";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 3212;
            dataRow["product_short_desc"] = "11 mm Anti static bubble";
            dataRow["product_upc"] = "3001-20221032";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 3213;
            dataRow["product_short_desc"] = "11 mm Anti static bubble";
            dataRow["product_upc"] = "3002-20221033";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 3214;
            dataRow["product_short_desc"] = "13 mm Anti static bubble";
            dataRow["product_upc"] = "3003-20221034";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 3215;
            dataRow["product_short_desc"] = "14 mm Anti static bubble";
            dataRow["product_upc"] = "3004-20221035";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 3216;
            dataRow["product_short_desc"] = "15 mm Anti static bubble";
            dataRow["product_upc"] = "3000-20221036";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 3217;
            dataRow["product_short_desc"] = "17 mm Anti static bubble";
            dataRow["product_upc"] = "3000-20221037";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 3218;
            dataRow["product_short_desc"] = "18 mm Anti static bubble";
            dataRow["product_upc"] = "3000-20221038";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 3219;
            dataRow["product_short_desc"] = "19 mm Anti static bubble";
            dataRow["product_upc"] = "3000-20221039";
            dt.Rows.Add(dataRow);

            dataRow = dt.NewRow();
            dataRow["productId"] = 3220;
            dataRow["product_short_desc"] = "209 mm Anti static bubble";
            dataRow["product_upc"] = "3000-20221040";
            dt.Rows.Add(dataRow);


            dataRow = dt.NewRow();
            dataRow["productId"] = 3221;
            dataRow["product_short_desc"] = "210 mm Anti static bubble";
            dataRow["product_upc"] = "3000-20221041";
            dt.Rows.Add(dataRow);

            return (dt);
        }
    }
}
