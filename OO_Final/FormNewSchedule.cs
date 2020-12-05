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
    public partial class FormNewSchedule : Form
    {
        private FakeRecipeRepository _Recipes;
        private FakeUserRepository _Users;
        private User _CurrentUser;
        private FakeScheduleRepository _Schedules;
        public Schedule _ToAdd = new Schedule();
        public FormNewSchedule(FakeRecipeRepository recipes, FakeUserRepository users, User curUser, FakeScheduleRepository schedule)
        {
            InitializeComponent();
            _Recipes = recipes;
            _Users = users;
            _CurrentUser = curUser;
            _Schedules = schedule;
        }

        private void FormNewSchedule_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            foreach(Recipe r in _Recipes.GetAll())
            {
                // Monday
                comboBoxMB.Items.Add(r.title);
                comboBoxML.Items.Add(r.title);
                comboBoxMD.Items.Add(r.title);
                // Tuesday
                comboBoxTuB.Items.Add(r.title);
                comboBoxTuL.Items.Add(r.title);
                comboBoxTuD.Items.Add(r.title);
                // Wednesday
                comboBoxWB.Items.Add(r.title);
                comboBoxWL.Items.Add(r.title);
                comboBoxWD.Items.Add(r.title);
                // Thursday
                comboBoxThB.Items.Add(r.title);
                comboBoxThL.Items.Add(r.title);
                comboBoxThD.Items.Add(r.title);
                // Friday
                comboBoxFB.Items.Add(r.title);
                comboBoxFL.Items.Add(r.title);
                comboBoxFD.Items.Add(r.title);
                // Saturday
                comboBoxSaB.Items.Add(r.title);
                comboBoxSaL.Items.Add(r.title);
                comboBoxSaD.Items.Add(r.title);
                // Sunday
                comboBoxSuB.Items.Add(r.title);
                comboBoxSuL.Items.Add(r.title);
                comboBoxSuD.Items.Add(r.title);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _ToAdd.name = textBoxName.Text;
            _ToAdd.creator = _CurrentUser;
            Recipe temp;
            // Monday
            if(comboBoxMB.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxMB.SelectedItem.ToString());
            }
            _ToAdd.Monday.Add(temp);

            if (comboBoxML.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxML.SelectedItem.ToString());
            }
            _ToAdd.Monday.Add(temp);

            if (comboBoxMD.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxMD.SelectedItem.ToString());
            }
            _ToAdd.Monday.Add(temp);

            // Tuesday
            if (comboBoxTuB.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxTuB.SelectedItem.ToString());
            }
            _ToAdd.Tuesday.Add(temp);

            if (comboBoxTuL.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxTuL.SelectedItem.ToString());
            }
            _ToAdd.Tuesday.Add(temp);

            if (comboBoxTuD.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxTuD.SelectedItem.ToString());
            }
            _ToAdd.Tuesday.Add(temp);

            // Wednesday
            if (comboBoxWB.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxWB.SelectedItem.ToString());
            }
            _ToAdd.Wednesday.Add(temp);

            if (comboBoxWL.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxWL.SelectedItem.ToString());
            }
            _ToAdd.Wednesday.Add(temp);

            if (comboBoxWD.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxWD.SelectedItem.ToString());
            }
            _ToAdd.Wednesday.Add(temp);

            // Thursday
            if (comboBoxThB.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxThB.SelectedItem.ToString());
            }
            _ToAdd.Thursday.Add(temp);

            if (comboBoxThL.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxThL.SelectedItem.ToString());
            }
            _ToAdd.Thursday.Add(temp);

            if (comboBoxThD.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxThD.SelectedItem.ToString());
            }
            _ToAdd.Thursday.Add(temp);

            // Friday
            if (comboBoxFB.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxFB.SelectedItem.ToString());
            }
            _ToAdd.Friday.Add(temp);

            if (comboBoxFL.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxFL.SelectedItem.ToString());
            }
            _ToAdd.Friday.Add(temp);

            if (comboBoxFD.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxFD.SelectedItem.ToString());
            }
            _ToAdd.Friday.Add(temp);

            // Saturday
            if (comboBoxSaB.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxSaB.SelectedItem.ToString());
            }
            _ToAdd.Saturday.Add(temp);

            if (comboBoxSaL.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxSaL.SelectedItem.ToString());
            }
            _ToAdd.Saturday.Add(temp);

            if (comboBoxSaD.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxSaD.SelectedItem.ToString());
            }
            _ToAdd.Saturday.Add(temp);

            // Sunday
            if (comboBoxSuB.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxSuB.SelectedItem.ToString());
            }
            _ToAdd.Sunday.Add(temp);

            if (comboBoxSuL.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxSuL.SelectedItem.ToString());
            }
            _ToAdd.Sunday.Add(temp);

            if (comboBoxSuD.SelectedItem == null)
            {
                temp = new Recipe();
                temp.title = " ";
                temp.instructions = " ";
            }
            else
            {
                temp = _Recipes.GetRecipeByName(comboBoxSuD.SelectedItem.ToString());
            }
            _ToAdd.Sunday.Add(temp);

            string result = _Schedules.Add(_ToAdd);
            if(result != FakeScheduleRepository.NO_ERROR)
            {
                MessageBox.Show(result, "error");
            }
            else
            {
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
