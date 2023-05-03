using CPProject.DataBaseModel;
using CPProject.DataBaseModel.types;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPProject.helpers
{
    public class DBhelpers
    {
        private static CinemaDataBase? DBInstance = null;
        private static CinemaDataBase DataBase
        {
            get
            {
                if (DBInstance == null)
                {
                    DBInstance = CinemaDataBase.Instance;
                }
                return DBInstance;
            }
        }

        public bool CheckIsUserBlocked(string userId)
        {
            return DataBase.BlockedUserCollection.Any(item => item.UserId == userId);
        }

        public int UnblockUserByTime()
        {
            int countUnblockedUser = 0;
            int countBlockedUser = DataBase.BlockedUserCollection.Count;
            for (int i = 0; i< countBlockedUser; i++)
            {
                DateTime AppointmentDate = DataBase.BlockedUserCollection[i].AppointmentDate;
                int minutesDuration = (int)DataBase.BlockedUserCollection[i].BlockDuration;
                Debug.WriteLine(DataBase.BlockedUserCollection[i].BlockDuration.ToString());
                if (minutesDuration < 1)
                    continue;
                if(AppointmentDate.AddMinutes(minutesDuration) < DateTime.Now)
                {
                    DataBase.BlockedUserCollection.RemoveAt(i);
                    countUnblockedUser++;
                    i--;
                }
            }
            return countUnblockedUser;
        }
    }
}
