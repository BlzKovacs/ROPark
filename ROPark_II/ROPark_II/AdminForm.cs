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
            List<string> cityList = new List<string>();
            List<string> regionList = new List<string>();
            List<string> parkPlaceList = new List<string>();
            List<string> userList = new List<string>();

            cityList = serv.getAllCites().ToList();
            regionList = serv.getAllRegions().ToList();
            parkPlaceList = serv.getAllParkPlaces().ToList();
            userList = serv.getAllUsers().ToList();

            foreach (string city in serv.getAllCites())
                listBoxCities.Items.Add(city);
            foreach (string region in regionList)
                listBoxRegions.Items.Add(region);
            foreach (string park in parkPlaceList)
                listBoxParkPlaces.Items.Add(park);
            foreach (string user in userList)
                listBoxUsers.Items.Add(user);
        }
    }
}
