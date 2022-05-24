using ROPark_II.Models;
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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

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
                password = EncodePassword(password);
     
                success = serv.checkUser(username, password);
                if (success)
                {
                    labelWelcome.Text = "Welcome back " + username + "!";

                    Account.userId = serv.getUserId(username);
                    Account.userName = username;
                    Account.isLogged = true;
                }
                else
                {
                    labelWelcome.Text = "Wrong username or password!";
                }
            }
        }

        public static string EncodePassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        
    }
}
