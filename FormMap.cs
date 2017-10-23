﻿/*	
	Gamma Analyzer - Controlling application for Burn
    Copyright (C) 2016  Norwegian Radiation Protection Authority

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
// Authors: Dag robole,

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using log4net;

namespace crash
{
    public partial class FormMap : Form
    {
        private FormContainer parent = null;
        private GASettings settings = null;
        private ILog log = null;

        private Session currentSession = null;
        private GMapOverlay overlay = new GMapOverlay();

        private Bitmap bmpBlue = new Bitmap(crash.Properties.Resources.marker_blue_10);
        private Bitmap bmpGreen = new Bitmap(crash.Properties.Resources.marker_green_10);
        private Bitmap bmpYellow = new Bitmap(crash.Properties.Resources.marker_yellow_10);
        private Bitmap bmpOrange = new Bitmap(crash.Properties.Resources.marker_orange_10);
        private Bitmap bmpRed = new Bitmap(crash.Properties.Resources.marker_red_10);

        public FormMap(FormContainer p, GASettings s, ILog l)
        {
            InitializeComponent();

            MdiParent = parent = p;
            settings = s;
            log = l;
        }

        private void FormMap_Load(object sender, EventArgs e)
        {
            try
            {
                gmnMap.Overlays.Add(overlay);
                gmnMap.Position = new PointLatLng(59.946534, 10.598574);

                gmnMap.MapProvider = ArcGIS_World_Topo_MapProvider.Instance;
                int idx = cboxMapProvider.FindString("ArcGIS World Topo");
                if (idx >= 0)
                    cboxMapProvider.SelectedIndex = idx;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void cboxMapMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboxMapMode.Text))
            {
                switch (cboxMapMode.Text)
                {
                    case "Server":
                        GMaps.Instance.Mode = AccessMode.ServerOnly;
                        break;
                    case "Cache":
                        GMaps.Instance.Mode = AccessMode.CacheOnly;
                        break;
                    default:
                        GMaps.Instance.Mode = AccessMode.ServerAndCache;
                        break;
                }
            }            
        }

        private void cboxMapProvider_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (!String.IsNullOrEmpty(cboxMapProvider.Text))
            {
                switch (cboxMapProvider.Text)
                {
                    case "Google Map":
                        gmnMap.MapProvider = GoogleMapProvider.Instance;
                        break;
                    case "Google Map Terrain":
                        gmnMap.MapProvider = GoogleTerrainMapProvider.Instance;
                        break;
                    case "Google Map Satellite":
                        gmnMap.MapProvider = GoogleSatelliteMapProvider.Instance;                        
                        break;
                    case "Open Street Map":
                        gmnMap.MapProvider = OpenStreetMapProvider.Instance;
                        break;
                    case "Open Street Map Quest":
                        gmnMap.MapProvider = OpenStreetMapQuestProvider.Instance;
                        break;
                    case "ArcGIS World Topo":
                        gmnMap.MapProvider = ArcGIS_World_Topo_MapProvider.Instance;
                        break;
                    case "ArcGIS World 2D":
                        gmnMap.MapProvider = ArcGIS_Imagery_World_2D_MapProvider.Instance;
                        break;                    
                    case "ArcGIS World Shaded":
                        gmnMap.MapProvider = ArcGIS_World_Shaded_Relief_MapProvider.Instance;
                        break;                    
                    case "Bing Map":
                        gmnMap.MapProvider = BingMapProvider.Instance;                         
                        break;
                    case "Bing Map Hybrid":
                        gmnMap.MapProvider = BingHybridMapProvider.Instance;
                        break;
                    case "Bing Map Satellite":
                        gmnMap.MapProvider = BingSatelliteMapProvider.Instance;
                        break;
                    case "Yahoo Map":
                        gmnMap.MapProvider = YahooMapProvider.Instance;
                        break;
                    case "Yahoo Map Hybrid":
                        gmnMap.MapProvider = YahooHybridMapProvider.Instance;                        
                        break;
                    case "Yahoo Map Satellite":                        
                        gmnMap.MapProvider = YahooSatelliteMapProvider.Instance;
                        break;
                }
            }
        }  
      
        private void RemoveAllMarkers()
        {
            if (overlay == null)
                return;

            for(int i = 0; i < overlay.Markers.Count; i++)            
                overlay.Markers.RemoveAt(i);
            overlay.Markers.Clear();
            overlay.Clear();
            gmnMap.Overlays.Remove(overlay);

            overlay = new GMapOverlay();
            gmnMap.Overlays.Add(overlay);
            gmnMap.Refresh();
        }

        public void SetSession(Session sess)
        {
            currentSession = sess;
            RemoveAllMarkers();

            foreach(Spectrum spec in currentSession.Spectrums)            
                AddMarker(spec);            

            if(currentSession.Spectrums.Count > 0)
                gmnMap.Position = new GMap.NET.PointLatLng(currentSession.Spectrums[0].Latitude, currentSession.Spectrums[0].Longitude);
        }

        public void AddMarker(Spectrum s)
        {
            if (currentSession == null)
                return;            

            Bitmap bmp = null;
            double dose = s.Doserate / 1000.0;

            if (dose <= 1.0)
                bmp = bmpBlue;
            else if (dose <= 5.0)
                bmp = bmpGreen;
            else if (dose <= 10.0)
                bmp = bmpYellow;
            else if (dose <= 20.0)
                bmp = bmpOrange;
            else bmp = bmpRed;

            // Add map marker            
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(s.Latitude, s.Longitude), bmp);
            marker.Tag = s;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = s.ToString() 
                + Environment.NewLine + "Latitude: " + s.Latitude
                + Environment.NewLine + "Longitude: " + s.Longitude
                + Environment.NewLine + "Altitude: " + s.Altitude;
            overlay.Markers.Add(marker);
        }                        

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {                                    
            Spectrum s = (Spectrum)item.Tag;
            parent.SetSelectedSessionIndex(s.SessionIndex);
        }

        public void SetSelectedSessionIndex(int index)
        {
            foreach (GMarkerGoogle m in overlay.Markers)
            {                   
                Spectrum s = (Spectrum)m.Tag;
                if (s.SessionIndex == index)                
                    m.ToolTipMode = MarkerTooltipMode.Always;                                
                else                
                    m.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            }
            gmnMap.Refresh();
        }

        public void SetSelectedSessionIndices(int index1, int index2)
        {
            foreach (GMarkerGoogle m in overlay.Markers)
            {
                Spectrum s = (Spectrum)m.Tag;
                if (s.SessionIndex >= index1 && s.SessionIndex <= index2)                
                    m.ToolTipMode = MarkerTooltipMode.Always;
                else                
                    m.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            }
            gmnMap.Refresh();
        }

        public void ClearSession()
        {
            currentSession = null;
            RemoveAllMarkers();
        }

        private void btnZoomToMax_Click(object sender, EventArgs e)
        {
            gmnMap.Zoom = (double)gmnMap.MinZoom;
        }

        private void btnZoomToMin_Click(object sender, EventArgs e)
        {
            gmnMap.Zoom = (double)gmnMap.MaxZoom;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            gmnMap.Zoom -= 1.0;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            gmnMap.Zoom += 1.0;
        }

        private void FormMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            gmnMap.Manager.CancelTileCaching();
        }
    }    
}
