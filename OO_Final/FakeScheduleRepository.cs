using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    public class FakeScheduleRepository : IScheduleRepository
    {
        public const string NO_ERROR = "";
        public const string ERROR = "Error - something went wrong!";
        public const string EMPTY_NAME_ERROR = "Schedule name is empty.";
        public const string DUPLICATE_NAME_ERROR = "Schedule name already exists.";
        public const string NO_SCHEDULE_FOUND_ERROR = "Schedule not found.";

        private static List<Schedule> _Schedules = new List<Schedule>();

        public string Add(Schedule schedule)
        {
            string newScheduleTitle = schedule.name.Trim();

            if (isDuplicate(newScheduleTitle))
            {
                return DUPLICATE_NAME_ERROR;
            }
            if(newScheduleTitle == "")
            {
                return EMPTY_NAME_ERROR;
            }

            _Schedules.Add(schedule);

            return NO_ERROR;
        }

        public List<Schedule> GetAll()
        {
            return _Schedules;
        }

        public string Remove(Schedule schedule)
        {
            int index = 0;
            foreach (Schedule s in _Schedules)
            {
                if (s.name == schedule.name)
                {
                    _Schedules.RemoveAt(index);
                    return NO_ERROR;
                }
                index++;
            }
            return NO_SCHEDULE_FOUND_ERROR;
        }

        private bool isDuplicate(string name)
        {
            bool isDup = false;
            foreach(Schedule s in _Schedules)
            {
                if(s.name == name)
                {
                    isDup = true;
                }
            }

            return isDup;
        }
    }
}
