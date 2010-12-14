using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Subgurim.Controles;

namespace BSIraq.framework
{
    public class House
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int? Rooms { get; set; }
        public int? Bathrooms { get; set; }
        public GLatLng LatLng { get; set; }

        public House(DataRow row)
        {
            ID = (int)row["ID"];
            Description = (string)row["Description"];
            Title = (string)row["Title"];
            Price = (double)row["Price"];
            Rooms = int.Parse(row["Rooms"].ToString()); // should be able to unbox
            Bathrooms = int.Parse(row["Bathrooms"].ToString());

            LatLng = new GLatLng((double)row["Lat"], (double)row["Lng"]);

        }

        public string Html()
        {
            return string.Format(@"
<h2>{0}</h2>
<table>
    <tr>
        <td>
            <img src='/housesImages/h{1}.bmp'>
        </td>
        <td valign=top>
            {2}
            <hr>
            Rooms: {3} - Baths:{4}
        </td>
    </tr>
</table>

<hr>
", Title, ID, Description, Rooms, Bathrooms);
        }
    }


}
