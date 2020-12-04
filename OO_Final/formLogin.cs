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
    public partial class FormLogin : Form
    {
        FakeUserRepository _UserRepository = new FakeUserRepository();
        public User _CurrentUser;
        public FormLogin()
        {
            InitializeComponent();
            _CurrentUser = new User();
            this.AcceptButton = buttonLogin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(_UserRepository.Login(textBoxUserName.Text, textBoxPassword.Text))
            {
                _UserRepository.SetAuthentication(textBoxUserName.Text, true);
                _CurrentUser = _UserRepository.GetByUserName(textBoxUserName.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password.", "Attention");
            }
        }
    }
}
