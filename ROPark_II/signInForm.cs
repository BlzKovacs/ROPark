using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROPark_II
{
    public partial class signInForm : Form
    {
        public signInForm()
        {
            InitializeComponent();
        }
        public String userName = null;
        public bool loginSuccess = false;
        localhost.WebService1 serv = new localhost.WebService1();
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            String username, password;
            Boolean success = false;

            if (textBoxName.Text.Equals("") || textBoxPassword.Equals(""))
                MessageBox.Show("Enter username and password!", "Error");
            else
            {
                username = textBoxName.Text.Trim();
                password = textBoxPassword.Text.Trim();
                success = serv.checkUser(username, password);
                if (success)
                {
                    userName = username;
                    labelWelcome.Text = "Welcome back " + username + "!";
                    loginSuccess = true;
                }
                else
                {
                    userName = null;
                    labelWelcome.Text = "Wrong username or password!";
                }
            }
        }
    }
}
