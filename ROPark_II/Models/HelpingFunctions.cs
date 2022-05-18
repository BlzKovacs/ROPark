using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROPark_II.Models;

namespace ROPark_II.Models
{
    public class HelpingFunctions
    {

        public List<ROPark_II.Models.City> convertOrasServiceClient(localhost.City[] list)
        {

            List<ROPark_II.Models.City> newList = new List<ROPark_II.Models.City>();

            for (int i = 0; i < list.Length; i++)
            {

                newList.Add(new ROPark_II.Models.City(list[i].id,
                                                      list[i].name,
                                                      list[i].mapX,
                                                      list[i].mapY));
            }

            return newList;
        }

    }

}
