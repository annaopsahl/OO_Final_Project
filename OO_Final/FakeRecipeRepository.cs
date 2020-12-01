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
                Recipe temp = new Recipe();
                temp.title = "Spaghetti";
                temp.instructions = "Cook noodles according to directions on box. Cook meat. Heat sauce and meat on stove.";
                Ingredient ing = new Ingredient();
                ing.amount = "1 can";
                ing.name = "Spaghetti Sauce";
                temp.ingredients.Add(ing);

                Ingredient ing1 = new Ingredient();
                ing1.amount = "1 lb";
                ing1.name = "Ground beef";
                temp.ingredients.Add(ing1);

                Ingredient ing2 = new Ingredient();
                ing2.amount = "1 box";
                ing2.name = "Spaghetti Noodles";
                temp.ingredients.Add(ing2);
                Add(temp);
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
        private bool IsDuplicateTitle(string recipeTitle)
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

        public Recipe GetRecipeByName(string name)
        {
            Recipe ret = new Recipe();
            ret.title = "";
            foreach(Recipe r in _Recipes)
            {
                if(r.title == name)
                {
                    ret = r;
                    return ret;
                }
            }
            return ret;
        }
    }
}
