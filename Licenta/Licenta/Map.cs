using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Licenta
{
    public partial class Map : Form
    {

        List<PointLatLng> _points;
        GMapOverlay markers = new GMapOverlay("markers");


        public Map()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void Map_Load(object sender, EventArgs e)
        {
          

            GMapProviders.GoogleMap.ApiKey = "AIzaSyAXn9zq9yB02SxtglnfCDnDibRDnnbxKM0";
            gMapControl1.ShowCenter = false;
            gMapControl1.SetPositionByKeywords("Timisoara, Romania");

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;

            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 7;

            gMapControl1.Refresh();

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
          if (txtLat.Text == "" && txtLong.Text == "")
          {
             return;
          }

          
            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {

            markers.Clear();
            _points.Clear();
            gMapControl1.Overlays.Clear();
            gMapControl1.Refresh();

        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {

            MapRoute route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 14); 
            GMapRoute r = new GMapRoute(route.Points, "My Route")
            {
                Stroke = new Pen(Color.Black, 2)
            };
            GMapOverlay routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            gMapControl1.Overlays.Add(routes);
            gMapControl1.Refresh();

            lblDist.Text = route.Distance + " km";
            lblDurata.Text = route.Duration;
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {

            if (_points.Count > 0)
            {
                double lat = _points[_points.Count - 1].Lat;
                double longt = _points[_points.Count - 1].Lng;

                gMapControl1.Position = new PointLatLng(lat, longt);

                PointLatLng point = new PointLatLng(lat, longt);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

                markers.Markers.Add(marker);
                gMapControl1.Overlays.Add(markers);
                gMapControl1.Refresh();

            }
        }


     
    }
}
