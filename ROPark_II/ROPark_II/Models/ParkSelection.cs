using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROPark_II.Models
{
    internal static class ParkSelection
    {
        public static int parkingPlaceId { get; set; }
        public static int regionId { get; set; }
        public static int cityId { get; set; }

        public static void reset()
        {
            parkingPlaceId = -1;
            regionId = -1;
            cityId = -1;
        }
    }
}
