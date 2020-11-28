using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    public class Schedule
    {
        public User creator { get; set; }
        public string name { get; set; }
        // recipe list
        public List<Recipe> Monday;
        public List<Recipe> Tuesday;
        public List<Recipe> Wednesday;
        public List<Recipe> Thursday;
        public List<Recipe> Friday;
        public List<Recipe> Saturday;
        public List<Recipe> Sunday;
    }
}
