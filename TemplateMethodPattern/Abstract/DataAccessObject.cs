using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Abstract
{
    abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;
        protected SqlConnection conn;

        public virtual void Connect()
        {
            connectionString = "Server=.\\DERYASQL;Database=NORTHWND;Trusted_Connection=true;";
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            conn.Close();
        }

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }

    }
}
