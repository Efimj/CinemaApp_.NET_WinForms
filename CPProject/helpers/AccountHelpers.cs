using CPProject.DataBaseModel;
using CPProject.DataBaseModel.types;

namespace CPProject.helpers
{
    public class AccountHelpers
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
            for (int i = 0; i < DataBase.BlockedUserCollection.Count; i++)
            {
                DateTime AppointmentDate = DataBase.BlockedUserCollection[i].AppointmentDate;
                int minutesDuration = (int)(BlockDurationType)Enum.GetValues(typeof(BlockDurationType)).GetValue(((int)DataBase.BlockedUserCollection[i].BlockDuration));
                if (minutesDuration < 1)
                    continue;
                if (AppointmentDate.AddMinutes(minutesDuration) < DateTime.Now)
                {
                    DataBase.BlockedUserCollection.Remove(DataBase.BlockedUserCollection[i].Id);
                    countUnblockedUser++;
                    i--;
                }
            }
            return countUnblockedUser;
        }

        public bool UpdateBlockedUserAndCheckIsUnblock(string userId)
        {
            this.UnblockUserByTime();
            return CheckIsUserBlocked(userId);
        }

    }
}
