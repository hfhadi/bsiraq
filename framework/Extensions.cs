using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace BSIraq.framework
{
    public static class Extensions
    {
        public static void Bind(this Repeater rptr, string sql)
        {
            Helper.Bind(rptr, sql);
        }
    }
}
