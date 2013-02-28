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
            private static DateTime SessionStartTime = new DateTime();

            public static void StartSession()
            {
                SessionStartTime = DateTime.UtcNow;
            }

            public static DateTime GetDBMTime()
            {
                TimeSpan TimeDiff = DateTime.UtcNow - SessionStartTime;
                return DBM_Start_Time + TimeDiff;
            }
        }
    }
}
