using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsterixDisplayAnalyser
{
    class P_Test
    {
        public static class TimeHanlder
        {
            public static DateTime DBM_Start_Time = new DateTime(2013, 1, 29, 10, 0, 0);
            public static DateTime SessionStartTime = new DateTime();
            public static bool SessionActive = false;

            public static void StartSession()
            {
                SessionStartTime = DateTime.UtcNow;
                SessionActive = true;

                MySqlProvider MySQL = new MySqlProvider();
                System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> DataRetreived = MySQL.GetFirstTimeFromTable(MySqlProvider.PredictionTableNumberType.One);
                DBM_Start_Time = DataRetreived[0].Time;
            }

            public static void StopSession()
            {
                SessionActive = false;
            }

            public static DateTime GetDBMTime()
            {
                TimeSpan TimeDiff = DateTime.UtcNow - SessionStartTime;
                return DBM_Start_Time + TimeDiff;
            }
        }
    }
}
