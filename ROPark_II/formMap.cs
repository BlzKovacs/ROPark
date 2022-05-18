using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using ROPark_II.Models;

namespace Proiect_II
{
    public partial class formMap : Form
    {
        private ROPark_II.localhost.WebService1 service;

        private String romaniaMap = "C:/Users/Asus/Desktop/ok/romaniaMap.jpg";
        private HelpingFunctions helpingFunctions = new HelpingFunctions();
        private List<OrasRectangle> listOrasRectangle = new List<OrasRectangle>();
        int selectedId = -1;

        public formMap()
        {
            InitializeComponent();

            service = new ROPark_II.localhost.WebService1();

            List<City> listOrase = new List<City>();
            listOrase = helpingFunctions.convertOrasServiceClient(this.service.getAllCites());
            var x = service.getAllCites();

            
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
                new Bitmap(romaniaMap), 470, 400);
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

                String[] list = service.getRegionByCityId(oras.id);

                listView_Regiuni.Items.Clear();

                for (int i = 0; i < list.Count(); i++)
                {
                    listView_Regiuni.Items.Add(new ListViewItem(list[i]));
                }

            }

        }

        private void pictureBox_Romania_Click(object sender, EventArgs e)
        {

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

    }
}
