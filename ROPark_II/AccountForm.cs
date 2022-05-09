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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        localhost.WebService1 serv = new localhost.WebService1();
        public Boolean accountLogged = true;
        public String accountUser;
        public void setLabels(String user)
        {
            if (user != null)
            {
                accountLogged = true;

                String[] userInfo;
                String fullName = "";
                userInfo = serv.getUser(user);

                for (int i = 0; i < userInfo.Length; i++)
                {

                    if (i == 1)
                        fullName = userInfo[i];
                    else if (i == 2)
                        labelName.Text = fullName.Trim() + " " + userInfo[i];
                    else if (i == 3)
                        labelPhone.Text = userInfo[i];
                    else if (i == 4)
                        labelEmail.Text = userInfo[i];
                }
                labelUser.Text = user;
                accountUser = user;
            }
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            accountLogged=false;
            accountUser = null;
            this.Close();
        }
    }

}
