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
        private const string _dbConnectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\salam\bsiraq\database\bsiraq.accdb;Persist Security Info=False;";

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

        public static DataTable GetTable(string sql)
        {
            using (var conn = new OleDbConnection(_dbConnectionString))
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
