using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROPark_II.Models
{
    public class City
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public int mapX { get; private set; }
        public int mapY { get; private set; }

        public City()
        {

        }
        public City(string name, int mapX, int mapY)
        {
            this.name = name;
            this.mapX = mapX;
            this.mapY = mapY;
        }
        public City(int id, string name, int mapX, int mapY)
        {
            this.id = id;
            this.name = name;
            this.mapX = mapX;
            this.mapY = mapY;
        }
    }
}
