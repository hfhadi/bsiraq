using System;
using System.Web.UI;
using BSIraq.framework;

namespace BSIraq
{
    public partial class SearchResult : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptr.Bind("Select * from House");
        }
    }
}