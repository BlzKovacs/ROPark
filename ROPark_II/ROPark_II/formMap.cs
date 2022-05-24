using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using ROPark_II.Models;

namespace ROPark_II
{
    public partial class formMap : Form
    {
        private ROPark_II.localhost.WebService1 service;

        private String romaniaMap = "romaniaMap.jpg";
        private HelpingFunctions helpingFunctions = new HelpingFunctions();
        private List<OrasRectangle> listOrasRectangle = new List<OrasRectangle>();
        private List<CityRegion> listRegiuni = new List<CityRegion>();
        private List<ParkingPlace> listParkingPlaces = new List<ParkingPlace>();
        int selectedId = -1;

        public formMap()
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

            if (oras != null)
            {

                selectedId = oras.id;
                this.Refresh();

                label_orasSelectat.Text = oras.name;

                listRegiuni = helpingFunctions.convertOrasRegionServiceClient(
                    this.service.getRegionByCityIdType(oras.id));

                listView_Regiuni.Items.Clear();

                for (int i = 0; i < listRegiuni.Count(); i++)
                {
                    listView_Regiuni.Items.Add(new ListViewItem(listRegiuni[i].name));
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

        private void listView_parkingPlace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_Regiuni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Regiuni.SelectedItems.Count > 0)
            {

                int id = this.helpingFunctions.getIdFromNameRegiuni(
                    listRegiuni,
                    listView_Regiuni.SelectedItems[0].Text);

                listParkingPlaces = helpingFunctions.convertParkingPlaceServiceClient(
                    this.service.getParkingPlacesByRegionId(id));

                listView_parkingPlace.Items.Clear();

                if (listParkingPlaces.Count != 0)
                {
                        for (int i = 0; i < listRegiuni.Count(); i++)
                        {
                            listView_parkingPlace.Items.Add(new ListViewItem(listParkingPlaces[i].name));
                        }
                }

            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            if (listView_Regiuni.SelectedItems.Count > 0 && listView_parkingPlace.SelectedItems.Count > 0)
            {

                int id = this.helpingFunctions.getIdFromNameParkingPlace(
                    listParkingPlaces,
                    listView_parkingPlace.SelectedItems[0].Text);

                ParkSelection.parkingPlaceId = id;
                ParkSelection.regionId = this.helpingFunctions.getIdFromNameRegiuni(
                    listRegiuni,
                    listView_Regiuni.SelectedItems[0].Text);
                ParkSelection.cityId = service.getCityId(label_orasSelectat.Text.Trim());
                ReserveParkingLot reserveParkingLot = new ReserveParkingLot(id);
                reserveParkingLot.Show();

            }
        }
    }
}
