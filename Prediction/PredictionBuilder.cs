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
            System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> Record = SqlProvider.GetOneRecordPerTimeAndACID(Table_Type, SharedData.LookAheadTime, ACID, false);

            // If prediction data for the given parameters exists 
            // then lets add it to the display list.
            if (Record.Count > 0)
            {
                GeoCordSystemDegMinSecUtilities.LatLongClass P_Pont = new GeoCordSystemDegMinSecUtilities.LatLongClass(double.Parse(Record[0].Lat), double.Parse(Record[0].Lon));

                PointLatLng PredictedPoint = new PointLatLng(P_Pont.GetLatLongDecimal().LatitudeDecimal, P_Pont.GetLatLongDecimal().LongitudeDecimal);
                PredictionMarker PM;

                string label = Record[0].ACID + "\n" + Record[0].Time.ToShortTimeString();

                switch (Table_Type)
                {
                    case MySqlProvider.PredictionTableNumberType.One:
                        PM = new PredictionMarker(Base_Position, Color.Magenta, PredictedPoint, label);
                        Overlay.Markers.Add(PM);
                        break;
                    case MySqlProvider.PredictionTableNumberType.Two:
                        PM = new PredictionMarker(Base_Position, Color.Blue, PredictedPoint, label);
                        Overlay.Markers.Add(PM);
                        break;
                    case MySqlProvider.PredictionTableNumberType.Three:
                        PM = new PredictionMarker(Base_Position, Color.Orange, PredictedPoint, label);
                        Overlay.Markers.Add(PM);
                        break;
                }
            }
        }
    }
}