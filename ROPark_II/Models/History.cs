using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROPark_II.Models
{
    public class History
    {
        public int historyId { get;  set; }

        public int userId { get;  set; }

        public string PlateNr { get;  set; }

        public int parkingLotId { get;  set; }
        
        public int parkingPlaceId { get;  set; }

        public int regionId { get;  set; }

        public int cityId { get;  set; }

        public DateTime date { get;  set; }

    }
}
