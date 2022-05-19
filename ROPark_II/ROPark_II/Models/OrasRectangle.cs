using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROPark_II.Models
{
    internal class OrasRectangle
    {

        private City Oras;

        public City oras
        {
            get { return Oras; }
            set { Oras = value; }
        }

        private Rectangle RRectangle;

        public Rectangle rectangle
        {
            get { return RRectangle; }
            set { RRectangle = value; }
        }

        public OrasRectangle(City oras, Rectangle rectangle)
        {
            this.Oras = oras;
            this.RRectangle = rectangle;
        }
    }
}
