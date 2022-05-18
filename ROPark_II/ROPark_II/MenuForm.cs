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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        
        private System.Windows.Forms.Form activeForm = null;
        //private System.Windows.Forms.Form openedChildForm;
        SignInForm signInForm = new SignInForm();
        SignUpForm signUpForm = new SignUpForm();

        AccountForm accountForm = new AccountForm();

        String userName = null;
        private void openChildFormInPanel(System.Windows.Forms.Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelSecondForm.Controls.Add(childForm);
            panelSecondForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void closeChildFormInPanel()
        {
            try
            {
                foreach (System.Windows.Forms.Form f in Application.OpenForms)
                {
                    if (f is SignInForm || f is SignUpForm || f is AccountForm)
                        f.Close();
                }
            }
            catch (Exception ex) { };

        }


        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            
            if (accountForm.accountLogged == false)
            {
                userName = null;
                signInForm.userName = null;
            }
            try
            {
                if (Form.ActiveForm != signInForm)
                {
                    openChildFormInPanel(signInForm);
                }
            }
            catch(Exception ex) 
            {
                this.signInForm = new SignInForm();
                signInForm.userName = userName;
                openChildFormInPanel(signInForm);
            };
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            closeChildFormInPanel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("dd / MM / yyyy HH: mm: ss");
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form.ActiveForm != signUpForm)
                {
                    openChildFormInPanel(signUpForm);
                }
            }
            catch (Exception ex)
            {

                this.signUpForm = new SignUpForm();
                openChildFormInPanel(signUpForm);
            };
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {

            if (signInForm.userName != null)
            {
                if (signInForm.userName.Equals("admin"))
                {
                    userName = "admin";
                    AdminForm adminForm = new AdminForm();
                    openChildFormInPanel(adminForm);
                }
                else
                {
                    setNewAccount();
                    openChildFormInPanel(accountForm);
                    accountForm.setLabels(signInForm.userName);
                    userName = signInForm.userName;
                }
            }

            else
                MessageBox.Show("Sign in first!", "Error");
            
        }

        private void setNewAccount()
        {
            
            this.accountForm = new AccountForm();
            accountForm.accountLogged = true;
        }

        public void setNewLogin(String username)
        {
            if (signInForm.userName != null)
            {
                this.signInForm = new SignInForm();
                signInForm.userName = username;
                if (!accountForm.accountLogged)
                {
                    setNewAccount();
                    accountForm.accountUser = username;
                }
            }
            else
            {
                this.signInForm = new SignInForm();
                signInForm.userName = username;
            }
        }
    }
}
