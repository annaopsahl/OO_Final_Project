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
    public partial class FormViewList : Form
    {
        private FakeScheduleRepository _Schedules;
        private FakeUserRepository _Users;
        private FakeRecipeRepository _Recipes;
        private User _CurrUser;
        private Schedule _CurrSchedule;
        public FormViewList(FakeRecipeRepository recipes, FakeUserRepository users, User currentUser, FakeScheduleRepository schedules)
        {
            InitializeComponent();
            _Schedules = schedules;
            _Users = users;
            _Recipes = recipes;
            _CurrUser = currentUser;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormViewList_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            foreach (Schedule s in _Schedules.GetAll())
            {
                if (s.creator.username == _CurrUser.username)
                {
                    comboBoxSchedule.Items.Add(s.name.ToString());
                }
            }
        }

        private void comboBoxSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CurrSchedule = _Schedules.GetScheduleByName(comboBoxSchedule.SelectedItem.ToString());

            for(int k = 0; k <= 3; k++)
            {
                foreach (Ingredient i in _CurrSchedule.Monday[k].ingredients)
                {
                    dataGridView1.Rows.Add(i.amount, i.name);
                }
                foreach (Ingredient i in _CurrSchedule.Tuesday[k].ingredients)
                {
                    dataGridView1.Rows.Add(i.amount, i.name);
                }
                foreach (Ingredient i in _CurrSchedule.Wednesday[k].ingredients)
                {
                    dataGridView1.Rows.Add(i.amount, i.name);
                }
                foreach (Ingredient i in _CurrSchedule.Thursday[k].ingredients)
                {
                    dataGridView1.Rows.Add(i.amount, i.name);
                }
                foreach (Ingredient i in _CurrSchedule.Friday[k].ingredients)
                {
                    dataGridView1.Rows.Add(i.amount, i.name);
                }
                foreach (Ingredient i in _CurrSchedule.Saturday[k].ingredients)
                {
                    dataGridView1.Rows.Add(i.amount, i.name);
                }
                foreach (Ingredient i in _CurrSchedule.Sunday[k].ingredients)
                {
                    dataGridView1.Rows.Add(i.amount, i.name);
                }
            }
            
           
        }
    }
}
