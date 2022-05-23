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
    public partial class EditRegionForm : Form
    {
        public EditRegionForm()
        {
            InitializeComponent();
        }
        private String newName, oldName;
        localhost.WebService1 serv = new localhost.WebService1();

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxNew.Text != "")
            {
                newName = textBoxNew.Text.ToUpper().Trim();
                if (serv.changeRegionName(oldName, newName))
                {
                    this.Close();
                }
                else
                    MessageBox.Show("An error occured.", "Error");
            }
            else
                MessageBox.Show("Enter new Region name!", "Error");
        }

        private void loadParkPlaces(String name)
        {
            List<String> parkPlaces = new List<String>();
            parkPlaces = serv.getParkPlacesForRegion(serv.getRegionId(name)).ToList();
            foreach (String parkPlace in parkPlaces)
                listBoxParkPlaces.Items.Add(parkPlace);
        }
        public void setForm(String name)
        {
            textBoxOld.Text = name;
            oldName = name;
            loadParkPlaces(name);
        }
    }
}
