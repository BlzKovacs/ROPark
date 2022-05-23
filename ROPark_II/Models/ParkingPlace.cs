using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROPark_II.Models
{
    public class ParkingPlace
    {

        public int id;
        public String name;
        public int nrSpaces;

        public ParkingPlace(int id, string name, int nrSpaces)
        {
            this.id = id;
            this.name = name;
            this.nrSpaces = nrSpaces;
        }

        public ParkingPlace()
        {
        }

    }
}
