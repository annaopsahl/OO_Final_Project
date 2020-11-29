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
        FakeRecipeRepository _Recipes;
        FakeUserRepository _Users;
        User _CurrentUser;
        FakeScheduleRepository _Schedules;
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
    }
}
