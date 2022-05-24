﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROPark_II.Models;

namespace ROPark_II
{
    public partial class ReserveParkingLot : Form
    {
        private ROPark_II.localhost.WebService1 service;
        private int idParkingPlace;
        private List<ParkingLot> listParkingLot = new List<ParkingLot>();
        private HelpingFunctions helpingFunctions = new HelpingFunctions();

        public ReserveParkingLot(int id)
        {
            InitializeComponent();

            service = new ROPark_II.localhost.WebService1();
            this.idParkingPlace = id;

            listParkingLot = helpingFunctions.convertParkingLotServiceClient(
                    this.service.getParkingLotByParkingPlaceId(idParkingPlace));

            listView_ParkingLot.Items.Clear();

            for (int i = 0; i < listParkingLot.Count(); i++)
            {
                listView_ParkingLot.Items.Add(new ListViewItem(listParkingLot[i].showStr));
            }

        }

        private void ReserveParkingLot_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView_ParkingLot.SelectedItems.Count > 0 && textBox1.Text.ToString() != "")
            {
                int id = this.helpingFunctions.getIdFromNameParkingLot(
                   listParkingLot,
                   listView_ParkingLot.SelectedItems[0].Text);
                try
                {
                    this.service.reserveParkingLot(id, textBox1.Text.ToUpper().Trim());

                    ROPark_II.localhost.History history = new localhost.History();
                    history.date = DateTime.Now;
                    history.parkingLotId = id;
                    history.regionId = ParkSelection.regionId;
                    history.cityId = ParkSelection.cityId;
                    history.parkingPlaceId = ParkSelection.parkingPlaceId;
                    history.userId = Account.userId;
                    history.PlateNr = textBox1.Text.Trim().ToUpper();

                    service.addHistory(history);

                    MessageBox.Show("Parking Lot rezervat.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Car does not exist in database");
                }
                this.Close();

                
            }
        }
    }
}
