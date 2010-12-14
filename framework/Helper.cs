using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace BSIraq.framework
{
    public static class Helper
    {
        private const string _salamDBConnectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\salam\bsiraq\database\bsiraq.accdb;Persist Security Info=False;";
        private const string _haydarDBConnectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\p4\Application\BSIraq\database\bsiraq.accdb;Persist Security Info=False;";

        private const string _haydarMachineName = "W764WIT287";


        public static void Bind(CompositeDataBoundControl view, string sql)
        {
            view.DataSource = GetTable(sql);
            view.DataBind();
        }

        public static void Bind(Repeater view, string sql)
        {
            view.DataSource = GetTable(sql);
            view.DataBind();
        }

        private static string ConnectionString()
        {
            return Environment.MachineName == _haydarMachineName ? _haydarDBConnectionString : _salamDBConnectionString;
        }

        public static DataTable GetTable(string sql)
        {
            using (var conn = new OleDbConnection(ConnectionString()))
            {
                var da = new OleDbDataAdapter(sql, conn);
                var dt = new DataTable();
                try
                {
                    da.Fill(dt);

                    return dt;
                }
                finally
                {
                    da.Dispose();
                    conn.Dispose();
                }
            }            
        }
    }
}
