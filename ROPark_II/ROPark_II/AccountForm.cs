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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        localhost.WebService1 serv = new localhost.WebService1();
        public void setLabels(String user)
        {
            if (user != null)
            {
                String[] userInfo;
                String fullName = "";
                userInfo = serv.getUser(user);
                String historyMsg,userName,parkPlaceName,regionName,cityName;

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

                foreach (localhost.History history in serv.getAllHistory())
                {
                    if (history.userId == Account.userId) 
                    {
                        userName = serv.getUserById(history.userId).Trim();
                        parkPlaceName = serv.getParkPlaceById(history.parkingPlaceId).Trim();
                        regionName = serv.getRegionById(history.regionId).Trim();
                        cityName = serv.getCityById(history.cityId).Trim();

                        historyMsg = "You have parked at City: " + cityName + "; Region: " + regionName
                            + "; Parking Place: " + parkPlaceName + " at: " + history.date;

                        listBoxHistory.Items.Add(historyMsg);
                    }
                }
            }
        }


        private System.Windows.Forms.Form activeForm = null;
        private void openChildFormInPanel(System.Windows.Forms.Form childForm)
        {
            try
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
            catch (Exception)
            {

            }
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            Account.logOut();
            this.Close();
        }

        private void buttonPark_Click(object sender, EventArgs e)
        {
            ParkInfoForm parkInfoForm = new ParkInfoForm();
            openChildFormInPanel(parkInfoForm);
        }
    }

}
