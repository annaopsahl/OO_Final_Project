using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    public interface IScheduleRepository
    {
        string Add(Schedule schedule);
        List<Schedule> GetAll();
        string Remove(Schedule schedule);
    }
}
