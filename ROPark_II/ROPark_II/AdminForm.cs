using ROPark_II.localhost;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        localhost.WebService1 serv = new localhost.WebService1();

        private void AdminForm_Load(object sender, EventArgs e)
        { 

            foreach (string city in serv.getAllCites())
                listBoxCities.Items.Add(city);
            foreach (string user in serv.getAllUsers())
                listBoxUsers.Items.Add(user);

            String historyMsg;
            String userName, parkplaceName,regionName,cityName;
            foreach (localhost.History history in serv.getAllHistory())
            {
                userName = serv.getUserById(history.userId).Trim();
                parkplaceName = serv.getParkPlaceById(history.parkingPlaceId).Trim();
                regionName = serv.getRegionById(history.regionId).Trim();
                cityName = serv.getCityById(history.cityId).Trim();

                historyMsg = "User: "+userName + " has parked at City: " + cityName + "; Region: " + regionName
                    + "; Parking Place: " + parkplaceName + " at: " + history.date;
                listBoxHistory.Items.Add(historyMsg);
            }
        }

        private System.Windows.Forms.Form activeForm = null;

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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxCities.SelectedIndex != -1)
            {
                EditCityForm editForm = new EditCityForm();
                String name = listBoxCities.SelectedItem.ToString();

                editForm.setForm(name);
                openChildFormInPanel(editForm);
            }
            else if (listBoxRegions.SelectedIndex != -1)
            {
                EditRegionForm editForm = new EditRegionForm();
                String name = listBoxRegions.SelectedItem.ToString();

                editForm.setForm(name);
                openChildFormInPanel(editForm);
            }
            else if (listBoxParkPlaces.SelectedIndex != -1)
            {
                EditParkPlaceForm editForm = new EditParkPlaceForm();
                String name = listBoxParkPlaces.SelectedItem.ToString();

                int nrSpaces = serv.getNrSpaces(name);
                editForm.setForm(name, nrSpaces);
                openChildFormInPanel(editForm);
            }
            else
                MessageBox.Show("You have to select a city, a region or a parking place!", "Error");
        }

        private void listBoxParkPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxParkPlaces.SelectedIndex != -1)
            {
                listBoxParkSpots.Items.Clear();

                listBoxUsers.SelectedIndex = -1;
                listBoxRegions.SelectedIndex = -1;
                listBoxCities.SelectedIndex = -1;
                listBoxParkSpots.SelectedIndex = -1;

                String parkPlaceName = listBoxParkPlaces.SelectedItem.ToString().Trim();
                int id = serv.getParkPlaceId(parkPlaceName);

                foreach (int parkSpot in serv.getParkSpotsForPlace(id))
                    listBoxParkSpots.Items.Add(parkSpot);
            }
        }

        private void listBoxRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRegions.SelectedIndex != -1)
            {
                listBoxParkPlaces.Items.Clear();
                listBoxParkSpots.Items.Clear();

                listBoxUsers.SelectedIndex = -1;
                listBoxCities.SelectedIndex = -1;
                listBoxParkPlaces.SelectedIndex = -1;
                listBoxParkSpots.SelectedIndex = -1;


                String regionName = listBoxRegions.SelectedItem.ToString().Trim();
                int id = serv.getRegionId(regionName);

                foreach (string parkPlace in serv.getParkPlacesForRegion(id))
                    listBoxParkPlaces.Items.Add(parkPlace);
            }
        }

        private void listBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCities.SelectedIndex != -1)
            {
                listBoxRegions.Items.Clear();
                listBoxParkPlaces.Items.Clear();
                listBoxParkSpots.Items.Clear();

                listBoxUsers.SelectedIndex = -1;
                listBoxRegions.SelectedIndex = -1;
                listBoxParkPlaces.SelectedIndex = -1;
                listBoxParkSpots.SelectedIndex = -1;

                String cityName = listBoxCities.SelectedItem.ToString().Trim();
                int id = serv.getCityId(cityName);

                foreach (string region in serv.getRegionsForCity(id))
                    listBoxRegions.Items.Add(region);

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listBoxParkSpots.SelectedIndex != -1)
            {
                int parkspot = Convert.ToInt32(listBoxParkSpots.SelectedItem.ToString());
                if (serv.deleteParkSpot(parkspot))
                {
                    listBoxParkSpots.Items.Remove(parkspot);
                }
                else
                    MessageBox.Show("An error occured.", "Error");
            }
            
            if (listBoxParkPlaces.SelectedIndex != -1)
            {

                String parkplace = listBoxParkPlaces.SelectedItem.ToString();
                if (serv.deleteParkPlace(parkplace))
                {
                    listBoxParkPlaces.Items.Remove(parkplace);
                }
                else
                    MessageBox.Show("You have to delete the Parking Spots first!.", "Error");
            }


            if (listBoxRegions.SelectedIndex != -1)
            {

                String region = listBoxRegions.SelectedItem.ToString();
                int regionId = serv.getRegionId(region);
                List<String> parkplaces = new List<string>();
                parkplaces = serv.getParkPlacesForRegion(regionId).ToList();

                if (parkplaces.Count == 0)
                {
                    if (serv.deleteRegion(region))
                    {
                        listBoxRegions.Items.Remove(region);
                    }
                    else
                        MessageBox.Show("An error occured.", "Error");
                }
                else
                    MessageBox.Show("Only an empty region can be deleted!\n Delete the parking places in the region first.", "Error");
            }

            if (listBoxCities.SelectedIndex != -1)
            {
                Boolean ok = true;
                String city = listBoxCities.SelectedItem.ToString();
                int cityId = serv.getCityId(city);
                List<String> regions = new List<string>();
                regions = serv.getRegionByCityId(cityId).ToList();

                List<String> parkplaces = new List<string>();
                foreach (String region in regions)
                {
                    parkplaces = serv.getParkPlacesForRegion(serv.getRegionId(region)).ToList();
                    if (parkplaces.Count != 0)
                        ok = false;
                }


                if (regions.Count == 0)
                {
                    if (serv.deleteCity(city))
                    {
                        listBoxCities.Items.Remove(city);
                    }
                    else
                        MessageBox.Show("An error occured.", "Error");
                }
                else if (!ok)
                {
                    MessageBox.Show("City contains regions with parking places.\nDelete the paring places first!", "Error");
                }
                else
                    MessageBox.Show("Only an empty city can be deleted!\n Delete the regions first.", "Error");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            listBoxCities.Items.Clear();
            listBoxRegions.Items.Clear();
            listBoxParkPlaces.Items.Clear();
            listBoxParkSpots.Items.Clear();

            foreach (string city in serv.getAllCites())
                listBoxCities.Items.Add(city);
            foreach (string user in serv.getAllUsers())
                listBoxUsers.Items.Add(user);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            EnterForm enterForm = new EnterForm();
            openChildFormInPanel(enterForm);
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            Account.logOut();
            this.Close();
        }

        private void listBoxParkSpots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxParkSpots.SelectedIndex != -1)
            {
                listBoxUsers.SelectedIndex = -1;
                listBoxRegions.SelectedIndex = -1;
                listBoxCities.SelectedIndex = -1;
                listBoxParkPlaces.SelectedIndex = -1;

            }
        }
    }
}
