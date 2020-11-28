using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    public interface IRecipeRepository
    {
        string Add(Recipe recipe);
        List<Recipe> GetAll();
        string Remove(Recipe recipe);
    }
}
