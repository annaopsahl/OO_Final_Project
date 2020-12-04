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
    public partial class FormDisplayRecipe : Form
    {
        FakeRecipeRepository _Recipes;
        Recipe _ToDisplay;
        public FormDisplayRecipe(string recipe, FakeRecipeRepository repo)
        {
            InitializeComponent();
            _Recipes = repo;
            _ToDisplay = _Recipes.GetRecipeByName(recipe);
        }

        private void FormDisplayRecipe_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            labelTitle.Text = _ToDisplay.title;
            foreach(Ingredient i in _ToDisplay.ingredients)
            {
                dataGridView1.Rows.Add(i.amount, i.name);
            }
            richTextBoxInstructions.Text = _ToDisplay.instructions;
            richTextBoxInstructions.ReadOnly = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
