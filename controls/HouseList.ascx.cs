using System;
using System.Web.UI;
using BSIraq.framework;

namespace BSIraq.controls
{
    public partial class HouseList : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void Build()
        {
            rptr.Bind("Select * from House");
        }
    }
}