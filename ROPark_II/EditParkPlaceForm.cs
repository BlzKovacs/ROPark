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
    public partial class EditParkPlaceForm : Form
    {
        public EditParkPlaceForm()
        {
            InitializeComponent();
        }
        private String newName, oldName;
        private int oldSpots, newSpots;
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
                newSpots = Convert.ToInt32(numericUpDown1.Value);
                oldName = textBoxOld.Text.ToUpper().Trim();
              
                if (serv.changeParkPlace(oldName, newName,newSpots))
                {
                    this.Close();
                }
                else
                    MessageBox.Show("An error occured.", "Error");
           
            }
            else if(textBoxNew.Text == "")
            {
                newSpots = Convert.ToInt32(numericUpDown1.Value);
                oldName = textBoxOld.Text.ToUpper().Trim();
                newName = oldName;

                if (serv.changeParkPlace(oldName, newName, newSpots))
                {
                    this.Close();
                }
                else
                    MessageBox.Show("An error occured.", "Error");
            }
            else 
                MessageBox.Show("Enter new ParkPlace name or Number of Spaces!", "Error");
        }
        public void setForm(String name,int spots)
        {
            textBoxOld.Text = name;
            oldName = name;
            oldSpots = spots;
            textBoxOldSpots.Text = oldSpots.ToString();
        }
    }
}
