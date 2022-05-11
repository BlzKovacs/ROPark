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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        localhost.WebService1 serv = new localhost.WebService1();
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            String username, firstName, LastName, password, email, phoneNr;
            if (textBoxName.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != ""
                && textBoxPhoneNr.Text != "" && textBoxEmail.Text != "" && textBoxPassword.Text != "")
            {
                username = textBoxName.Text.Trim();
                firstName = textBoxFirstName.Text.Trim();
                LastName = textBoxLastName.Text.Trim();
                password = textBoxPassword.Text.Trim();
                email = textBoxEmail.Text.Trim();
                phoneNr = textBoxPhoneNr.Text.Trim();

                Boolean userExists = serv.checkUserName(username);
                if (userExists)
                    labelMessage.Text = "Username already exists! Try a different one.";

                else
                {
                    serv.addUser(username, firstName, LastName, email, phoneNr, password);
                    labelMessage.Text = "All done. Welcome to ROPark! Now log in with your account.";
                }
            }
            else
                labelMessage.Text = "Enter data into every field!";
        }
    }
}
