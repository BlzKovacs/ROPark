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

        public List<ROPark_II.Models.CityRegion> convertOrasRegionServiceClient(localhost.CityRegion[] list)
        {
            
             List<ROPark_II.Models.CityRegion> newList = new List<ROPark_II.Models.CityRegion>();

            for (int i = 0; i < list.Length; i++)
            {

                newList.Add(new ROPark_II.Models.CityRegion(list[i].id,
                                                        list[i].name));
            }
             


            return newList;
        }

        public List<ROPark_II.Models.ParkingPlace> convertOrasRegionServiceClient(localhost.ParkingPlace[] list)
        {

            List<ROPark_II.Models.ParkingPlace> newList = new List<ROPark_II.Models.ParkingPlace>();

            for (int i = 0; i < list.Length; i++)
            {

                newList.Add(new ROPark_II.Models.ParkingPlace(list[i].id,
                                                        list[i].name,
                                                        list[i].nrSpaces));
            }



            return newList;
        }

        public int getIdFromNameRegiuni(List<CityRegion> list, String name)
        {

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].name.Equals(name))
                {
                    return list[i].id;
                }
            }

            return 1;

        }

    }

}
