using System;
using System.Web.UI;

namespace BSIraq
{
    public partial class SearchResult : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ctrlHouseList.Build();
=======
            rptr.Bind("Select * from House");
            
>>>>>>> 1d617138f88b6695e971d22c747daeacf8f33682
        }
    }
}