using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using ROPark_II.Models;
using Microsoft.VisualBasic;

namespace ROPark_II
{
    public partial class EnterForm : Form
    {
        private ROPark_II.localhost.WebService1 service;

        private String romaniaMap = "romaniaMap.jpg";
        private HelpingFunctions helpingFunctions = new HelpingFunctions();
        private List<OrasRectangle> listOrasRectangle = new List<OrasRectangle>();
        int selectedId = -1;

        public EnterForm()
        {
            InitializeComponent();

            service = new ROPark_II.localhost.WebService1();

            List<City> listOrase = new List<City>();
            listOrase = helpingFunctions.convertOrasServiceClient(this.service.getAllCitesType());
            var x = service.getAllCitesType();


            for (int i = 0; i < listOrase.Count(); i++)
            {

                listOrasRectangle.Add(new OrasRectangle(
                    listOrase[i],
                        new Rectangle(
                        listOrase[i].mapX,
                        listOrase[i].mapY,
                        25,
                        25
                        )
                    )
                    );

            }

            this.Refresh();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox_Romania.Image = ResizeImage(
                new Bitmap(romaniaMap), 775, 545);
            pictureBox_Romania.SizeMode = PictureBoxSizeMode.AutoSize;
            pannel_menu.Height = pictureBox_Romania.Image.Height;

        }

        private void pbImage_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < listOrasRectangle.Count; i++)
            {
                e.Graphics.DrawRectangle(new Pen(Color.White, 1), listOrasRectangle[i].rectangle);


                if (selectedId != -1)
                {
                    if (listOrasRectangle[i].oras.id == selectedId)
                    {
                        e.Graphics.FillRectangle(
                            new SolidBrush(Color.FromArgb(70, 0, 128, 0)),
                            listOrasRectangle[i].rectangle);
                    }
                }
                else
                {
                    e.Graphics.FillRectangle(
                    new SolidBrush(Color.FromArgb(70, 128, 128, 128)),
                        listOrasRectangle[i].rectangle);
                }

            }

        }

        private void clickOnImage(object sender, MouseEventArgs e)
        {
            City oras = getOrasFromClick(e.X, e.Y);

            listViewParkPlace.Items.Clear();
            listView_Regiuni.Items.Clear();
            if (oras != null)
            {

                selectedId = oras.id;
                this.Refresh();

                label_orasSelectat.Text = oras.name;

                String[] list = service.getRegionByCityId(oras.id);

                listView_Regiuni.Items.Clear();

                for (int i = 0; i < list.Count(); i++)
                {
                    listView_Regiuni.Items.Add(new ListViewItem(list[i]));
                }

            }
            else
            {
                String cityName = null;
                cityName = Interaction.InputBox("Enter the name of the City:", "Enter City", null);

                if (cityName != "")
                {
                    if (!service.CityExists(cityName))
                    {
                        City city = new City(cityName, e.X, e.Y);
                        service.addCity(city.name, city.mapX, city.mapY);
                        updateCity();
                        pictureBox_Romania.Refresh();
                    }
                    else
                        MessageBox.Show("City already exists!", "Error");
                }
                
            }

        }


        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private City getOrasFromClick(int x, int y)
        {

            for (int i = 0; i < listOrasRectangle.Count; i++)
            {

                if (listOrasRectangle[i].rectangle.
                    Contains(new System.Drawing.Point(x, y)))
                {
                    return listOrasRectangle[i].oras;
                }

            }

            return null;
        }

        private void buttonRegion_Click(object sender, EventArgs e)
        {
            if (label_orasSelectat.Text != "- ; -")
            {
                String regionName = null;
                String cityName = label_orasSelectat.Text.Trim();
                int cityId = service.getCityId(cityName);
                regionName = Interaction.InputBox("Enter the name of the Region:", "Enter Region", null).ToUpper();

                if (regionName != "")
                {
                    if (!service.RegionExists(regionName,cityId))
                    {
                        service.addRegion(cityId, regionName);
                        listView_Regiuni.Items.Add(regionName);
                    }
                    else
                        MessageBox.Show("Region already exists!", "Error");
                           
                }
            }
            else
                MessageBox.Show("Select a city first!", "Error");
               
        }

        private void updateCity()
        {
            List<City> listOrase = new List<City>();
            listOrase = helpingFunctions.convertOrasServiceClient(this.service.getAllCitesType());
            var x = service.getAllCitesType();


            for (int i = 0; i < listOrase.Count(); i++)
            {

                listOrasRectangle.Add(new OrasRectangle(
                    listOrase[i],
                        new Rectangle(
                        listOrase[i].mapX,
                        listOrase[i].mapY,
                        25,
                        25
                        )
                    )
                    );

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonParkPlace_Click(object sender, EventArgs e)
        {
            if (listView_Regiuni.SelectedItems.Count != 0)
            {
                String parkPlaceName = null;
                String regionName = listView_Regiuni.SelectedItems[0].Text;
                int regionId = service.getRegionId(regionName);

                parkPlaceName = Interaction.InputBox("Enter the name of the Parking Place:", "Enter Parking Place", null).ToUpper();
                if (parkPlaceName != "")
                {
                    if (!service.ParkingPlaceExists(parkPlaceName,regionId))
                    {
                        try
                        {
                            int nrSpaces = Convert.ToInt32(Interaction.InputBox("Enter number of spaces for Parking Place:", "Enter Parking Place", null));
                            
                            if (nrSpaces > 0 && nrSpaces <= 1000)
                            {
                                if (service.addParkingPlace(regionId, parkPlaceName, nrSpaces))
                                {
                                    if (service.addSpaces(service.getParkPlaceId(parkPlaceName), nrSpaces))
                                        listViewParkPlace.Items.Add(parkPlaceName);
                                    else
                                        MessageBox.Show("Parking spots could not be added...", "Error");
                                }
                            }
                            else
                                MessageBox.Show("Enter an even number from 1 to 1000!", "Error");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Enter an even number from 1 to 1000!", "Error");
                        }
                    }
                    else
                        MessageBox.Show("Region already exists!", "Error");

                }
                
            }
            else
                MessageBox.Show("Select a Region first!", "Error");
        }

        private void listView_Regiuni_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewParkPlace.Items.Clear();
            try
            {
                String regionName = listView_Regiuni.SelectedItems[0].Text;
                int regionId = service.getRegionId(regionName);
               
                List<String> parkPlaces = service.getParkPlacesForRegion(regionId).ToList();

                foreach (String parkPlace in parkPlaces)
                {
                    listViewParkPlace.Items.Add(parkPlace);
                }
            }
            catch (Exception)
            { }
            
        }
    }
}
