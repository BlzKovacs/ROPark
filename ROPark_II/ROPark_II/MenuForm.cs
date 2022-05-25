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
            }
            finally
            {
                foreach(Control c in panel1.Controls)
                {
                    c.Enabled = true;
                }
                buttonSignIn.Enabled = false;
            };
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            closeChildFormInPanel();
            foreach (Control c in panel1.Controls)
            {
                c.Enabled = true;
            }
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
            }
            finally
            {
                foreach (Control c in panel1.Controls)
                {
                    c.Enabled = true;
                }
                buttonSignUp.Enabled = false;
            }
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
                foreach (Control c in panel1.Controls)
                {
                    c.Enabled = true;
                }
                buttonAccount.Enabled = false;

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
                }
                finally
                {
                    foreach (Control c in panel1.Controls)
                    {
                        c.Enabled = true;
                    }
                    buttonPark.Enabled = false;
                }
            }
            else
                MessageBox.Show("Sign in to start parking!", "Sign in first");
        }
    }
}
