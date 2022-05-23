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
    public partial class EditCityForm : Form
    {
        public EditCityForm()
        {
            InitializeComponent();
            
        }
        private String oldName;
        private String newName;

        localhost.WebService1 serv = new localhost.WebService1();
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxNew.Text != "")
            {
                newName = textBoxNew.Text.ToUpper().Trim();
                if (serv.changeCityName(oldName, newName))
                {
                    this.Close();
                }
                else
                    MessageBox.Show("An error occured.", "Error");
            }
            else
                MessageBox.Show("Enter new City name!", "Error");
        }
        
        private void loadRegions(String name)
        {
            List<String> regions = new List<String>();
            regions = serv.getRegionByCityId(serv.getCityId(name)).ToList();
            foreach(String region in regions)
                listBoxRegions.Items.Add(region);
        }
        public void setForm(String name)
        {
            textBoxOld.Text = name;
            oldName = name;
            loadRegions(name);
        }

        private void listBoxRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRegions.SelectedIndex != -1)
            {
                listBoxParkPlaces.Items.Clear();

                listBoxParkPlaces.SelectedIndex = -1;
                List<String> parkPlaceList = new List<String>();
                String regionName = listBoxRegions.SelectedItem.ToString().Trim();
                int id = serv.getRegionId(regionName);
                parkPlaceList = serv.getParkPlacesForRegion(id).ToList();

                foreach (string parkPlace in parkPlaceList)
                    listBoxParkPlaces.Items.Add(parkPlace);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
