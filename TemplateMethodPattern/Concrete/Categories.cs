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
    class Categories : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Categories ----");
            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }

        public override void Select()
        {
            string sql = "SELECT CategoryName FROM Categories";


            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet,"Categories");
        }
    }
}
