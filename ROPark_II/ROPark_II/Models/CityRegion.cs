using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROPark_II.Models
{
    public class CityRegion
    {

        public int id;
        public String name;

        public CityRegion(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public CityRegion()
        {
        }

    }
}
