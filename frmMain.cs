using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Net.Http;

namespace ISSTracker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool mouseDown;
        private Point offSet;
        GMapProvider activeMapType;
        private async void getData()
        {
            try
            {
                HttpClient client = new HttpClient();
                string data = await client.GetStringAsync("https://api.wheretheiss.at/v1/satellites/25544");
                data = data.Remove(0, data.IndexOf(',') + 1);
                data = data.Remove(0, data.IndexOf(',') + 1);
                data = data.Remove(0, data.IndexOf(':') + 1);
                string latStr = data.Substring(0, data.IndexOf(','));
                data.Remove(0, data.IndexOf(',') + 1);
                data = data.Remove(0, data.IndexOf(':') + 1);
                string lngStr = data.Substring(0, data.IndexOf(','));
                float lat = float.Parse(latStr.Replace('.', ','));
                float lng = float.Parse(lngStr.Replace('.', ','));
                tmrTimer.Enabled = true;
                plotISS(lat, lng);
            }
            catch (Exception)
            {
                tmrTimer.Enabled = false;
            }
        }

        private void plotISS(float lat, float lng)
        { 
            gmapMap.Overlays.Clear();
            gmapMap.DragButton = MouseButtons.Left;
            gmapMap.MapProvider = activeMapType;
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            Bitmap markerIcon = (Bitmap)Image.FromFile("img/icon.png");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), markerIcon);
            gmapMap.Overlays.Add(markersOverlay);
            markersOverlay.Markers.Add(marker);
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            offSet.X = e.X;
            offSet.Y = e.Y;

            mouseDown = true;
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point curScreenLocation = PointToScreen(e.Location);
                Location = new Point(curScreenLocation.X - offSet.X, curScreenLocation.Y - offSet.Y);
            }
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlMenu.Visible = !pnlMenu.Visible;
        }

        private void chxNegative_CheckedChanged(object sender, EventArgs e)
        {
            gmapMap.NegativeMode = chxNegative.Checked;
        }

        private void cbxMapType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMapType.SelectedIndex == 1)
            {
                activeMapType = GMapProviders.GoogleSatelliteMap;
                getData();
            }
            else
            {
                activeMapType = GMapProviders.GoogleTerrainMap;
                getData();
            }
        }

        private void nupRefreshRate_ValueChanged(object sender, EventArgs e)
        {
            tmrTimer.Interval = (int)nupRefreshRate.Value * 1000;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            getData();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            activeMapType = GMapProviders.GoogleTerrainMap;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrTimer.Enabled = false;
        }
    }
}
