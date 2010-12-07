using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//For Gmap
using Subgurim.Controls;
using Subgurim.Controles;
using System.Drawing;

namespace BSIraq
{
    public partial class AddHouse : System.Web.UI.Page
    {
        readonly GLatLng _latlng = new GLatLng(33.303708016355245, 44.3720680475235);

        GMarker _markerDraggable = new GMarker();
        GMarkerOptions _mOpts = new GMarkerOptions();

        protected void Page_Load(object sender, EventArgs e)
        {
            gMap.setCenter(_latlng, 7, GMapType.GTypes.Hybrid);
            gMap.enableHookMouseWheelToZoom = true;

            //show the postion on the map
            gMap.addControl(new GControl(GControl.extraBuilt.TextualCoordinatesControl));

            //show the cursor on the map  
            gMap.addControl(new GControl(GControl.extraBuilt.MarkCenter));

            gMap.setCenter(_latlng, 5, GMapType.GTypes.Satellite);

            var mOpts = new GMarkerOptions {draggable = true};

            var mkr = new GMarker {options = mOpts, javascript_GLatLng = "point"};


            var sb = "function(overlay, point) {if (overlay){alert(overlay.id);} else{#ID#}}";
            sb = sb.Replace("#ID#", mkr.ToString(gMap.GMap_Id));
            
            var listener2 = new GListener(gMap.GMap_Id, GListener.Event.click, sb);
            gMap.addListener(listener2);


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // TextBox1.Text = GControl.extraBuilt.TextualCoordinatesControl   ;
        }

        public  void Me(GAjaxServerEventArgs e)
        {
        }

        protected string gMap_Click(object s, GAjaxServerEventArgs e)
        {
            var marker = new GMarker(e.point);

            var window = new GInfoWindow(marker,
            string.Format(@"
            <b>GLatLngBounds</b><br />
            SW = {0}<br/>
            NE = {1}
            ",
            e.bounds.getSouthWest().ToString(),
            e.bounds.getNorthEast().ToString())
            , true);

            return window.ToString(e.map); }
        }

    
}
