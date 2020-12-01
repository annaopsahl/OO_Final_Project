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
            labelMB.Text = _CurrSchedule.Monday[0].title;
            labelML.Text = _CurrSchedule.Monday[1].title;
            labelMD.Text = _CurrSchedule.Monday[2].title;
            // Tuesday
            labelTuB.Text = _CurrSchedule.Tuesday[0].title;
            labelTuL.Text = _CurrSchedule.Tuesday[1].title;
            labelTuD.Text = _CurrSchedule.Tuesday[2].title;
            // Wednesday
            labelWB.Text = _CurrSchedule.Wednesday[0].title;
            labelWL.Text = _CurrSchedule.Wednesday[1].title;
            labelWD.Text = _CurrSchedule.Wednesday[2].title;
            // Thursday
            labelThB.Text = _CurrSchedule.Thursday[0].title;
            labelThL.Text = _CurrSchedule.Thursday[1].title;
            labelThD.Text = _CurrSchedule.Thursday[2].title;
            // Friday
            labelFB.Text = _CurrSchedule.Friday[0].title;
            labelFL.Text = _CurrSchedule.Friday[1].title;
            labelFD.Text = _CurrSchedule.Friday[2].title;
            // Saturday
            labelSaB.Text = _CurrSchedule.Saturday[0].title;
            labelSaL.Text = _CurrSchedule.Saturday[1].title;
            labelSaD.Text = _CurrSchedule.Saturday[2].title;
            // Sunday
            labelSuB.Text = _CurrSchedule.Sunday[0].title;
            labelSuL.Text = _CurrSchedule.Sunday[1].title;
            labelSuD.Text = _CurrSchedule.Sunday[2].title;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
