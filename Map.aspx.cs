using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

//For Gmap
using Subgurim.Controls;
using Subgurim.Controles;
using System.Collections.Generic;
using System.Drawing;

namespace BSIraq
{
    public partial class Map : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            //مواقع البيوت على الخريطه
            
            //some test

            //مدينة بغداد
            GLatLng latlng = new GLatLng(33.303708016355245, 44.3720680475235);
            GLatLng latlng1 = new GLatLng(33.30494095074294, 44.3713653087616);
            GLatLng latlng2 = new GLatLng(33.306223184015565, 44.37358617782593);
            //مدينة كربلاء
            GLatLng latlng3 = new GLatLng(32.615039238431486, 44.03835028409958);
            GLatLng latlng4 = new GLatLng(32.61548656961024, 44.03770387172699);
            GLatLng latlng5 = new GLatLng(32.61622759816053, 44.037339091300964);

            
            
            GMap1.enableHookMouseWheelToZoom = true;
        
            GMap1.setCenter(latlng, 7, GMapType.GTypes.Hybrid);

            

            //اضهار صورة مقربة للموقع

            //GMarker marker = new GMarker(latlng);
            //GInfoWindowOptions IWoptions = new GInfoWindowOptions(17, GMapType.GTypes.Hybrid);
            //GShowMapBlowUp mbUp = new GShowMapBlowUp(marker, false, IWoptions);
            //gMap.addShowMapBlowUp(mbUp);


            GInfoWindowTabs iwTabs = new GInfoWindowTabs();

            GMarker icono1 = new GMarker(latlng);
            iwTabs.gMarker = icono1;
            iwTabs.point = latlng;

            List<GInfoWindowTab> tabs = new List<GInfoWindowTab>();
            
                tabs.Add(new GInfoWindowTab("معلومات عامه " , "نكتب بعض المعلومات"));
                tabs.Add(new GInfoWindowTab("صور ", "نضغ بعض الصور"));
                tabs.Add(new GInfoWindowTab("الإتصال ", "<div class='info'  >الإتصال بالمكتب العقاري</div>"));
            

            iwTabs.tabs = tabs;
            GMap1.addInfoWindowTabs(iwTabs);






            GMarker icono2 = new GMarker(latlng3);
            GInfoWindow window2 = new GInfoWindow(icono2, "عماره <b>عماره سلام ان شاء الله</b>", false, GListener.Event.click);
            GMap1.addInfoWindow(window2);




            GInfoWindowTabs iwTabs2 = new GInfoWindowTabs();

            GMarker icono = new GMarker(latlng5);

            iwTabs2.gMarker = icono;
            iwTabs2.tabs = tabs;
            GMap1.addInfoWindowTabs(iwTabs2); 


            

           
        }
    }
}
