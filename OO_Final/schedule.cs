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
        public List<Recipe> Monday = new List<Recipe>();
        public List<Recipe> Tuesday = new List<Recipe>();
        public List<Recipe> Wednesday = new List<Recipe>();
        public List<Recipe> Thursday = new List<Recipe>();
        public List<Recipe> Friday = new List<Recipe>();
        public List<Recipe> Saturday = new List<Recipe>();
        public List<Recipe> Sunday = new List<Recipe>();
    }
}
