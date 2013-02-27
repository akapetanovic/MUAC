using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GMap.NET.WindowsForms;
using GMap.NET;
using System.Drawing;

namespace AsterixDisplayAnalyser
{
    class PredictionBuilder
    {

        public void Build_Prediction_Marker(PointLatLng Base_Position, string ACID, MySqlProvider.PredictionTableNumberType Table_Type, ref GMapOverlay Overlay)
        {
            MySqlProvider SqlProvider = new MySqlProvider();
            System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> Record = SqlProvider.GetAllDataForTimeAndACID(Table_Type, SharedData.LookAheadTime, ACID);

            // If prediction data for the given parameters exists 
            // then lets add it to the display list.
            if (Record.Count > 0)
            {
                int LAT_DEG, LAT_MIN, LAT_SEC;
                string tmp = "" + Record[0].Lat[0] + Record[0].Lat[1];
                LAT_DEG = int.Parse(tmp);
                tmp = "" + Record[0].Lat[2] + Record[3].Lat[1];
                LAT_MIN = int.Parse(tmp);
                tmp = "" + Record[0].Lat[4] + Record[5].Lat[1];
                LAT_SEC = int.Parse(tmp);

                int LON_DEG, LON_MIN, LON_SEC;
                tmp = "" + Record[0].Lon[0] + Record[0].Lon[1];
                LON_DEG = int.Parse(tmp);
                tmp = "" + Record[0].Lon[2] + Record[3].Lon[1];
                LON_MIN = int.Parse(tmp);
                tmp = "" + Record[0].Lon[4] + Record[5].Lon[1];
                LON_SEC = int.Parse(tmp);

                GeoCordSystemDegMinSecUtilities.LatLongPrefix Lat_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.Not_Valid;
                GeoCordSystemDegMinSecUtilities.LatLongPrefix Lon_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.Not_Valid;
                switch (Record[0].Lat[6])
                {
                    case 'E':
                        Lat_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.E;
                        break;
                    case 'W':
                        Lat_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.W;
                        break;
                    case 'N':
                        Lat_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.N;
                        break;
                    case 'S':
                        Lat_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.S;
                        break;
                }
                switch (Record[0].Lon[6])
                {
                    case 'E':
                        Lon_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.E;
                        break;
                    case 'W':
                        Lon_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.W;
                        break;
                    case 'N':
                        Lon_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.N;
                        break;
                    case 'S':
                        Lon_Prefix = GeoCordSystemDegMinSecUtilities.LatLongPrefix.S;
                        break;
                }

                GeoCordSystemDegMinSecUtilities.LatLongClass P_Pont = new GeoCordSystemDegMinSecUtilities.LatLongClass(LAT_DEG, LAT_MIN, LAT_SEC, Lat_Prefix, LON_DEG, LON_MIN, LON_SEC, Lon_Prefix);

                PointLatLng PredictedPoint = new PointLatLng(P_Pont.GetLatLongDecimal().LatitudeDecimal, P_Pont.GetLatLongDecimal().LongitudeDecimal);
                PredictionMarker PM;

                switch (Table_Type)
                {
                    case MySqlProvider.PredictionTableNumberType.One:
                        PM = new PredictionMarker(Base_Position, Color.Magenta, PredictedPoint);
                        Overlay.Markers.Add(PM);
                        break;
                    case MySqlProvider.PredictionTableNumberType.Two:
                        PM = new PredictionMarker(Base_Position, Color.Blue, PredictedPoint);
                        Overlay.Markers.Add(PM);
                        break;
                    case MySqlProvider.PredictionTableNumberType.Three:
                        PM = new PredictionMarker(Base_Position, Color.Orange, PredictedPoint);
                        Overlay.Markers.Add(PM);
                        break;
                }
            }
        }
    }
}