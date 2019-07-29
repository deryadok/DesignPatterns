using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Concrete
{
    class Products : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Products ----");
            DataTable dataTable = dataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }
            Console.WriteLine();
        }

        public override void Select()
        {
            string sql = "SELECT ProductName FROM Products";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connectionString);

            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet,"Products");
        }
    }
}
