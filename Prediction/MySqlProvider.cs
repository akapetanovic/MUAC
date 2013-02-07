using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AsterixDisplayAnalyser
{
    class MySqlProvider
    {

        // This is the My Sql Connection string
        private string connString = "server=localhost;User Id=root;database=prediction";

        public MySqlProvider()
        {
          connString = "server=" + Properties.Settings.Default.MySqlServer + 
              ";User Id=" + Properties.Settings.Default.MySqlUser + ";database=" + Properties.Settings.Default.mySqlDatabase;
        }
        
        // This class encapsulates one row of prediction data
        public class PredictionDataSetOneRow
        {
            public string ACID = null;
            public DateTime Time;
            public string Lat = null;
            public string Lon = null;
            public string FL = null;
            public string Accuracy = null;
        }

        // Enumeration, specifying prediction table/algorithim type
        public enum PredictionTableNumberType { One, Two, Three };


        public bool IsConnectionOK()
        {
            bool ConnectionOK = true;

            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch
            {
                ConnectionOK = false;
            }

            conn.Close();
            return ConnectionOK;
        }
        
        // This method returns all available data from the given table number.
        public System.Collections.Generic.List<PredictionDataSetOneRow> GetDataSet(PredictionTableNumberType TableNumber)
        {
            System.Collections.Generic.List<PredictionDataSetOneRow> DataRetreived = new System.Collections.Generic.List<PredictionDataSetOneRow>();

            string PredictionTable = PredictionTable = "prediction1";
            switch (TableNumber)
            {
                case PredictionTableNumberType.One:
                    PredictionTable = "prediction1";
                    break;
                case PredictionTableNumberType.Two:
                    PredictionTable = "prediction2";
                    break;
                case PredictionTableNumberType.Three:
                    PredictionTable = "prediction3";
                    break;
                default:
                    PredictionTable = "prediction1";
                    break;
            }

            //            string sql = @" 
            //                SELECT
            //                    acid,
            //                    time,
            //                    lat,
            //                    lon,
            //                    fl,
            //                    acc
            //                FROM " + PredictionTable;

            //            // All data only latest tracks
            //            string sql = @" 
            //                SELECT
            //                    acid,
            //                    max(time),
            //                    lat,
            //                    lon,
            //                    fl,
            //                    acc
            //                FROM " + PredictionTable +
            //                " WHERE 1 GROUP by acid ORDER by time DESC";

            // Get the data for ceratin time range
            string sql = @" 
                SELECT
                    acid,
                    time,
                    lat,
                    lon,
                    fl,
                    acc
                FROM " + PredictionTable +
                " WHERE time BETWEEN '2013-01-29 10:14:00' AND '2013-01-29 10:14:00' GROUP by acid ORDER by time DESC";

            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    PredictionDataSetOneRow OneRow = new PredictionDataSetOneRow();
                    if (rdr.GetString(0).Length > 0)
                    {
                        OneRow.ACID = rdr.GetString(0);
                        OneRow.Time = rdr.GetDateTime(1);
                        OneRow.Lat = rdr.GetString(2);
                        OneRow.Lon = rdr.GetString(3);
                        OneRow.FL = rdr.GetString(4);
                        OneRow.Accuracy = rdr.GetString(5);
                        DataRetreived.Add(OneRow);
                    }
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return DataRetreived;
        }
    }
}
