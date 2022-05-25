using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            String username, firstName, lastName, password, email, phoneNr;
            if (textBoxName.Text != "" && textBoxPhoneNr.Text != "" && textBoxEmail.Text != ""
                && textBoxPassword.Text != "" && textBoxLastName.Text != "" && textBoxFirstName.Text != "")
            {
                username = textBoxName.Text.Trim();
                firstName = textBoxFirstName.Text.Trim();
                lastName = textBoxLastName.Text.Trim();
                email = textBoxEmail.Text.Trim();
                phoneNr = textBoxPhoneNr.Text.Trim();
                password = textBoxPassword.Text.Trim();
                password = EncodePassword(password);

                if (email.Contains("@") && email.Contains("."))
                {

                    Boolean userExists = serv.checkUserName(username);
                    if (userExists)
                        labelMessage.Text = "Username already exists! Try a different one.";
                    else
                    {
                        String msg = "Hey " + firstName + "!\n" + "Thank you for joining ROPark!\n" +
                        "\nYour account has the following details: \nUsername: " + username + "\nFirst name: " + firstName + "\nLast name: " + lastName
                        + "\nEmail: " + email + "\nPhone Number: " + phoneNr + "\n\nHave a great day!";

                        if (serv.sendEmail(email,msg))
                        {
                            serv.addUser(username, firstName, lastName, email, phoneNr, password);
                            labelMessage.Text = "All done. Welcome to ROPark! Now log in with your account.";
                            MessageBox.Show("Sign up complete!\nAn email was sent to your adress!", "Welcome");
                        }
                        else
                            MessageBox.Show("Enter a valid email adress!", "Error");
                    }
                }
                else
                    MessageBox.Show("Enter a valid email adress!", "Error");

            }
            else
                labelMessage.Text = "Enter data into every field!";
        }
    }
}
