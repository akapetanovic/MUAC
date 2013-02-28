using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsterixDisplayAnalyser
{
    class MySqlDateTimeUtility
    {
        //DateTimeOut = "'2013-1-29 10:14:00'";
        public static string BuildMySqlDateTimeString(TimeSpan TimeToAdd, bool Is_DBM_Lookup, MySqlProvider.PredictionTableNumberType Table)
        {
            DateTime T;
            if ( SharedData.UseDBM_Replay_Time == false)
                T = DateTime.UtcNow + TimeToAdd;
            else
            {
                if (Is_DBM_Lookup)
                {
                    MySqlProvider MySQL = new MySqlProvider();
                    System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> DataRetreived = MySQL.GetFirstTimeFromTable(Table);
                    T = DataRetreived[0].Time + TimeToAdd;
                }
                else
                    T = P_Test.TimeHanlder.GetDBMTime() + TimeToAdd;
            }

            string DateTimeOut = "'" + T.Year.ToString() + "-" + T.Month + "-" + T.Day.ToString() + " " + T.Hour.ToString() + ":" + T.Minute.ToString() + ":" + T.Second.ToString() + "'";
            return DateTimeOut;
        }
    }
}
