using System;
using System.Web.UI;

namespace BSIraq
{
    public partial class SearchResult : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlHouseList.Build();
        }
    }
}