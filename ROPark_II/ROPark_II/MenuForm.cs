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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        
        private System.Windows.Forms.Form activeForm = null;
        SignInForm signInForm = new SignInForm();
        SignUpForm signUpForm = new SignUpForm();
        formMap formMap = new formMap();
        AccountForm accountForm = new AccountForm();

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
            catch (Exception) { };

        }


        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Form.ActiveForm != signInForm)
                {
                    openChildFormInPanel(signInForm);
                }
            }
            catch(Exception) 
            {
                this.signInForm = new SignInForm();  
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
            catch (Exception)
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

            if (Account.isLogged)
            {
                if (Account.userName.Equals("admin"))
                {
                    AdminForm adminForm = new AdminForm();
                    openChildFormInPanel(adminForm);
                }
                else
                {
                    this.accountForm = new AccountForm();
                    openChildFormInPanel(accountForm);
                    accountForm.setLabels(Account.userName);
                }
            }
            else
                MessageBox.Show("Sign in first!", "Error");
            
        }


        private void buttonPark_Click(object sender, EventArgs e)
        {

            if (Account.isLogged)
            {
                try
                {
                    if (Form.ActiveForm != this.formMap)
                    {
                        openChildFormInPanel(this.formMap);
                    }
                }
                catch (Exception)
                {
                    this.formMap = new formMap();
                    openChildFormInPanel(formMap);
                };
            }
            else
                MessageBox.Show("You have to be logged in to start parking!", "Log in first");
        }
    }
}
