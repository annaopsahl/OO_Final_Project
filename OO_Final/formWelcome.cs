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
    public partial class FormWelcome : Form
    {
        private User _CurrentUser = new User();
        private FakeUserRepository _Users = new FakeUserRepository();
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // Force the user to log in to the application
            DialogResult isOK = DialogResult.OK;
            while(!_CurrentUser.isLoggedIn && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentUser = login._CurrentUser;
                login.Dispose();
            }
            if(isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            // change text if needed
        }
    }
}
