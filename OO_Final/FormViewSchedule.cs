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
    public partial class FormViewSchedule : Form
    {
        private FakeScheduleRepository _Schedules;
        private FakeUserRepository _Users;
        private FakeRecipeRepository _Recipes;
        private User _CurrUser;
        private Schedule _CurrSchedule;
        public FormViewSchedule(FakeRecipeRepository recipes, FakeUserRepository users, User currentUser, FakeScheduleRepository schedules)
        {
            InitializeComponent();
            _Schedules = schedules;
            _Users = users;
            _Recipes = recipes;
            _CurrUser = currentUser;
            
        }

        private void FormViewSchedule_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // add schedules to comboBox
            foreach(Schedule s in _Schedules.GetAll())
            {
                if(s.creator.username == _CurrUser.username)
                {
                    comboBoxName.Items.Add(s.name.ToString());
                }
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CurrSchedule = _Schedules.GetScheduleByName(comboBoxName.SelectedItem.ToString());
            if(_CurrSchedule == null)
            {
                MessageBox.Show("Could not find schedule.", "Error");
                this.Close();
            }
            // Monday
            buttonMB.Text = _CurrSchedule.Monday[0].title;
            if(buttonMB.Text != " ")
            {
                buttonMB.Enabled = true;
            }
            buttonML.Text = _CurrSchedule.Monday[1].title;
            if (buttonML.Text != " ")
            {
                buttonML.Enabled = true;
            }
            buttonMD.Text = _CurrSchedule.Monday[2].title;
            if (buttonMD.Text != " ")
            {
                buttonMD.Enabled = true;
            }
            // Tuesday
            buttonTuB.Text = _CurrSchedule.Tuesday[0].title;
            if (buttonTuB.Text != " ")
            {
                buttonTuB.Enabled = true;
            }
            buttonTuL.Text = _CurrSchedule.Tuesday[1].title;
            if (buttonTuL.Text != " ")
            {
                buttonTuL.Enabled = true;
            }
            buttonTuD.Text = _CurrSchedule.Tuesday[2].title;
            if (buttonTuD.Text != " ")
            {
                buttonTuD.Enabled = true;
            }
            // Wednesday
            buttonWB.Text = _CurrSchedule.Wednesday[0].title;
            if (buttonWB.Text != " ")
            {
                buttonWB.Enabled = true;
            }
            buttonWL.Text = _CurrSchedule.Wednesday[1].title;
            if (buttonWL.Text != " ")
            {
                buttonWL.Enabled = true;
            }
            buttonWD.Text = _CurrSchedule.Wednesday[2].title;
            if (buttonWD.Text != " ")
            {
                buttonWD.Enabled = true;
            }
            // Thursday
            buttonThB.Text = _CurrSchedule.Thursday[0].title;
            if(buttonThB.Text != " ")
            {
                buttonThB.Enabled = true;
            }
            buttonThL.Text = _CurrSchedule.Thursday[1].title;
            if (buttonThL.Text != " ")
            {
                buttonThL.Enabled = true;
            }
            buttonThD.Text = _CurrSchedule.Thursday[2].title;
            if (buttonThD.Text != " ")
            {
                buttonThD.Enabled = true;
            }
            // Friday
            buttonFB.Text = _CurrSchedule.Friday[0].title;
            if (buttonFB.Text != " ")
            {
                buttonFB.Enabled = true;
            }
            buttonFL.Text = _CurrSchedule.Friday[1].title;
            if (buttonFL.Text != " ")
            {
                buttonFL.Enabled = true;
            }
            buttonFD.Text = _CurrSchedule.Friday[2].title;
            if (buttonFD.Text != " ")
            {
                buttonFD.Enabled = true;
            }
            // Saturday
            buttonSaB.Text = _CurrSchedule.Saturday[0].title;
            if (buttonSaB.Text != " ")
            {
                buttonSaB.Enabled = true;
            }
            buttonSaL.Text = _CurrSchedule.Saturday[1].title;
            if (buttonSaL.Text != " ")
            {
                buttonSaL.Enabled = true;
            }
            buttonSaD.Text = _CurrSchedule.Saturday[2].title;
            if (buttonSaD.Text != " ")
            {
                buttonSaD.Enabled = true;
            }
            // Sunday
            buttonSuB.Text = _CurrSchedule.Sunday[0].title;
            if (buttonSuB.Text != " ")
            {
                buttonSuB.Enabled = true;
            }
            buttonSuL.Text = _CurrSchedule.Sunday[1].title;
            if (buttonSuL.Text != " ")
            {
                buttonSuL.Enabled = true;
            }
            buttonSuD.Text = _CurrSchedule.Sunday[2].title;
            if (buttonSuD.Text != " ")
            {
                buttonSuD.Enabled = true;
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewRecipe_Click(object sender, EventArgs e)
        {
            /*string recipe = buttonViewRecipe.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();*/
        }

        private void buttonMB_Click(object sender, EventArgs e)
        {
            string recipe = buttonMB.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonML_Click(object sender, EventArgs e)
        {
            string recipe = buttonML.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonMD_Click(object sender, EventArgs e)
        {
            string recipe = buttonMD.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonTuB_Click(object sender, EventArgs e)
        {
            string recipe = buttonTuB.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonTuL_Click(object sender, EventArgs e)
        {
            string recipe = buttonTuL.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonTuD_Click(object sender, EventArgs e)
        {
            string recipe = buttonTuD.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonWB_Click(object sender, EventArgs e)
        {
            string recipe = buttonWB.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonWL_Click(object sender, EventArgs e)
        {
            string recipe = buttonWL.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonWD_Click(object sender, EventArgs e)
        {
            string recipe = buttonWD.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonThB_Click(object sender, EventArgs e)
        {
            string recipe = buttonThB.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonThL_Click(object sender, EventArgs e)
        {
            string recipe = buttonThL.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonThD_Click(object sender, EventArgs e)
        {
            string recipe = buttonThD.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonFB_Click(object sender, EventArgs e)
        {
            string recipe = buttonFB.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonFL_Click(object sender, EventArgs e)
        {
            string recipe = buttonFL.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonFD_Click(object sender, EventArgs e)
        {
            string recipe = buttonFD.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonSaB_Click(object sender, EventArgs e)
        {
            string recipe = buttonSaB.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonSaL_Click(object sender, EventArgs e)
        {
            string recipe = buttonSaL.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonSaD_Click(object sender, EventArgs e)
        {
            string recipe = buttonSaD.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonSuB_Click(object sender, EventArgs e)
        {
            string recipe = buttonSuB.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonSuL_Click(object sender, EventArgs e)
        {
            string recipe = buttonSuL.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }

        private void buttonSuD_Click(object sender, EventArgs e)
        {
            string recipe = buttonSuD.Text;
            FormDisplayRecipe form = new FormDisplayRecipe(recipe, _Recipes);
            form.ShowDialog();
            form.Dispose();
        }
    }
}
