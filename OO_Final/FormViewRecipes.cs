using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Final
{
    public partial class FormViewRecipes : Form
    {
        FakeRecipeRepository _Recipes;
        public FormViewRecipes(FakeRecipeRepository repo)
        {
            InitializeComponent();
            this.CenterToScreen();
            _Recipes = repo;
            foreach(Recipe r in _Recipes.GetAll())
            {
                comboBoxRecipes.Items.Add(r.title);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormViewRecipes_Load(object sender, EventArgs e)
        {

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            string recipe = comboBoxRecipes.SelectedItem.ToString();
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }
    }
}
