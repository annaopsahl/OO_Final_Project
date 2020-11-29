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
    public partial class FormAddRecipe : Form
    {
        User _CurrentUser;
        FakeRecipeRepository _Recipes;
        FakeUserRepository _Users;
        Recipe toAdd = new Recipe();
        public FormAddRecipe(User curUser, FakeUserRepository user, FakeRecipeRepository repo)
        {
            _CurrentUser = curUser;
            _Recipes = repo;
            _Users = user;
            InitializeComponent();
        }

        private void FormAddRecipe_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void buttonAddIngredients_Click(object sender, EventArgs e)
        {
            FormAddIngredient formAdd = new FormAddIngredient();
            formAdd.ShowDialog();
            toAdd.ingredients = formAdd._Ingredients;
            formAdd.Dispose();
            labelDone.Visible = true;
        }

        private void textTitle_TextChanged(object sender, EventArgs e)
        {
            buttonAddIngredients.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            toAdd.title = textTitle.Text;
            toAdd.instructions = richTextBoxInstructions.Text;
            toAdd.creator = _CurrentUser;
            string result = _Recipes.Add(toAdd);
            if(result != FakeRecipeRepository.NO_ERROR)
            {
                MessageBox.Show(result, "Error");
            }
            else
            {
                this.Close();
            }
        }
    }
}
