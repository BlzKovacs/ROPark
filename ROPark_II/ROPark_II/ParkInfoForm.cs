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
    public partial class ParkInfoForm : Form
    {
        public ParkInfoForm()
        {
            InitializeComponent();
   
        }
        localhost.WebService1 service = new localhost.WebService1();
        DateTime date;
        private void ParkInfoForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (localhost.History history in service.getAllHistory())
            {
                if(history.userId == Account.userId && !service.isSpotFree(history.parkingLotId))
                {
                    if (!listBoxSpots.Items.Contains(history.parkingLotId))
                    {
                        listBoxSpots.Items.Add(history.parkingLotId);
                        i++;
                    }
                }
                
            }
            if(i == 0)
            {
                MessageBox.Show("You dont have any reservations.", "No reservations");
                this.Close();   
            }
        }

        private void listBoxSpots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxSpots.SelectedIndex != -1)
            {
                foreach (localhost.History history in service.getAllHistory())
                {
                    if(history.parkingLotId == Convert.ToInt32(listBoxSpots.SelectedItem))
                    {
                        labelCity.Text = service.getCityById(history.cityId);
                        labelRegion.Text = service.getRegionById(history.regionId);
                        labelPlace.Text = service.getParkPlaceById(history.parkingPlaceId);
                        labelPlate.Text = history.PlateNr.ToString();
                        date = history.date;
                    }
                }
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if(listBoxSpots.SelectedIndex != -1)
            {
                TimeSpan ts = DateTime.Now - date ;
                double cost = (double)ts.TotalSeconds /3600;
                buttonFinish.Visible = true;
                labelCost.Visible = true;
                labelCost.Text = "Total cost is: "+cost;
                labelThanks.Visible = true;

                buttonPay.Visible = true;
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                int spotId = Convert.ToInt32(listBoxSpots.SelectedItem);
                service.finishParking(spotId);
                listBoxSpots.Items.Remove(listBoxSpots.SelectedItem);

                labelCost.Visible = false;
                buttonPay.Visible = false;
                labelThanks.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error");
            }
        }
    }
}
