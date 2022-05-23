using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROPark_II.Models
{
    public class ParkingLot
    {

        public int id;
        public String plateNr;
        public int state;
        public String showStr;
        public ParkingLot()
        {
        }

        public ParkingLot(int id, string plateNr, int state)
        {
            this.id = id;
            this.plateNr = plateNr;
            this.state = state;
        }
    }
}
