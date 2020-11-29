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
    public partial class FormAddIngredient : Form
    {
        public List<Ingredient> _Ingredients = new List<Ingredient>();
        public FormAddIngredient()
        {
            InitializeComponent();
        }

        private void FormAddIngredient_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void buttonAddToRecipe_Click(object sender, EventArgs e)
        {
            if(textBoxAmount.Text == "" || textBoxIngredient.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                Ingredient temp = new Ingredient();
                temp.amount = textBoxAmount.Text;
                temp.name = textBoxIngredient.Text;
                // check for duplicates
                bool dup = false;
                foreach (Ingredient i in _Ingredients)
                {
                    if (i.name == temp.name)
                    {
                        dup = true;
                    }
                }
                if (dup == false)
                {
                    _Ingredients.Add(temp);
                    string label = temp.amount + " " + temp.name;
                    labelIngredientAdded.Text = label;
                    labelAdded.Visible = true;
                    labelIngredientAdded.Visible = true;
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (textBoxAmount.Text == "" || textBoxIngredient.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                Ingredient temp = new Ingredient();
                temp.amount = textBoxAmount.Text;
                temp.name = textBoxIngredient.Text;
                // check for duplicates
                bool dup = false;
                foreach(Ingredient i in _Ingredients)
                {
                    if(i.name == temp.name)
                    {
                        dup = true;
                    }
                }
                if(dup == false)
                {
                    _Ingredients.Add(temp);
                    string label = temp.amount + " " + temp.name;
                    labelIngredientAdded.Text = label;
                    labelAdded.Visible = true;
                    labelIngredientAdded.Visible = true;
                }                   
            }

            if (_Ingredients.Count() == 0)
            {
                var result = MessageBox.Show("No ingredients were added, are you sure you're done?", "Attention", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
