using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    public class FakeRecipeRepository : IRecipeRepository
    {
        public const string NO_ERROR = "";
        public const string ERROR = "Error - something went wrong!";
        public const string EMPTY_TITLE_ERROR = "Recipe title is empty.";
        public const string DUPLICATE_TITLE_ERROR = "Recipe title already exists.";
        public const string NO_RECIPE_FOUND_ERROR = "Recipe not found.";

        private static List<Recipe> _Recipes = new List<Recipe>();
        public FakeRecipeRepository()
        {
            if(_Recipes.Count == 0)
            {
                // add recipes here
            }
        }

        public string Add(Recipe recipe)
        {
            string newRecipeTitle = recipe.title.Trim();
            if (IsDuplicateTitle(newRecipeTitle))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            if(newRecipeTitle == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            _Recipes.Add(recipe);

            return NO_ERROR;
        }

        public List<Recipe> GetAll()
        {
            return _Recipes;
        }

        public string Remove(Recipe recipe)
        {
            int index = 0;
            foreach(Recipe r in _Recipes)
            {
                if(r.title == recipe.title)
                {
                    _Recipes.RemoveAt(index);
                    return NO_ERROR;
                }
                index++;
            }
            return NO_RECIPE_FOUND_ERROR;
        }

        // check if duplicate title
        public bool IsDuplicateTitle(string recipeTitle)
        {
            bool isDup = false;
            foreach(Recipe r in _Recipes)
            {
                if(recipeTitle == r.title)
                {
                    isDup = true;
                }
            }
            return isDup;
        }
    }
}
