using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    public class Recipe
    {
        public User creator { get; set; }
        public string title { get; set; }
        public string instructions { get; set; }
        public List<Ingredient> ingredients;
    }
}
