using ROPark_II.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Services;

namespace WebServer
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        SqlConnection sqlConnection = new SqlConnection();
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection myCon = new SqlConnection();
        public WebService1()
        {

            myCon.ConnectionString = connectionString;
        }

        [WebMethod]
        public List<String> getAllCites()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataSet dataSet_Cities = new DataSet();
            SqlDataAdapter dataAdapter_Cities = new SqlDataAdapter("SELECT * FROM City", connection);
            dataAdapter_Cities.Fill(dataSet_Cities, "CityName");

            List<String> list = new List<String>();

            foreach (DataRow row in dataSet_Cities.Tables["CityName"].Rows)
            {
                list.Add(row.ItemArray.GetValue(1).ToString());
            }

            sqlConnection.Close();

            return list;
        }

        [WebMethod]
        public List<City> getAllCitesCityType()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataSet dataSet_Oras = new DataSet();
            SqlDataAdapter dataAdapter_Univ = new SqlDataAdapter("SELECT * FROM City", connection);
            DataTable dtOras = new DataTable();
            dataAdapter_Univ.Fill(dataSet_Oras, "City");

            List<City> list = new List<City>();

            foreach (DataRow row in dataSet_Oras.Tables["City"].Rows)
            {

                City city = new City();
                city.id = Convert.ToInt32(row.ItemArray.GetValue(0));
                city.name = row.ItemArray.GetValue(1).ToString();
                city.mapX = Convert.ToInt32(row.ItemArray.GetValue(2));
                city.mapY = Convert.ToInt32(row.ItemArray.GetValue(3));

                list.Add(city);

            }


            sqlConnection.Close();

            return list;
        }

        [WebMethod]
        public List<String> getAllRegions()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataSet dataSet_Regions = new DataSet();
            SqlDataAdapter dataAdapter_Cities = new SqlDataAdapter("SELECT * FROM CityRegion", connection);
            dataAdapter_Cities.Fill(dataSet_Regions, "RegionName");

            List<String> list = new List<String>();

            foreach (DataRow row in dataSet_Regions.Tables["RegionName"].Rows)
            {
                list.Add(row.ItemArray.GetValue(2).ToString());
            }

            sqlConnection.Close();

            return list;
        }

        [WebMethod]
        public List<String> getAllParkPlaces()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataSet dataSet_ParkPlace = new DataSet();
            SqlDataAdapter dataAdapter_ParkPlace = new SqlDataAdapter("SELECT * FROM ParkingPlaces", connection);
            dataAdapter_ParkPlace.Fill(dataSet_ParkPlace, "ParkPlaceName");

            List<String> list = new List<String>();

            foreach (DataRow row in dataSet_ParkPlace.Tables["ParkPlaceName"].Rows)
            {
                list.Add(row.ItemArray.GetValue(2).ToString());
            }

            sqlConnection.Close();

            return list;
        }

        [WebMethod]
        public List<String> getAllUsers()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataSet dataSet_Users = new DataSet();
            SqlDataAdapter dataAdapter_Users = new SqlDataAdapter("SELECT * FROM Users", connection);
            dataAdapter_Users.Fill(dataSet_Users, "UserName");

            List<String> list = new List<String>();

            foreach (DataRow row in dataSet_Users.Tables["UserName"].Rows)
            {
                list.Add(row.ItemArray.GetValue(1).ToString());
            }

            sqlConnection.Close();

            return list;
        }

        [WebMethod]
        public String getCityById(int id)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataSet dataSet_City = new DataSet();
            String sqlString = "SELECT * FROM City WHERE CityID=" + id;
            SqlDataAdapter dataAdapter_City = new SqlDataAdapter(sqlString, connection);

            dataAdapter_City.Fill(dataSet_City, "CityName");

            foreach (DataRow row in dataSet_City.Tables["CityName"].Rows)
            {
                String oras = row.ItemArray.GetValue(1).ToString();
                sqlConnection.Close();
                return oras;
            }

            sqlConnection.Close();
            return "NU EXISTA IN BAZA DE DATE";
        }

        [WebMethod]
        public List<String> getRegionByCityId(int idCity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataSet dataSet_Regions = new DataSet();
            String sqlString = "SELECT * FROM CityRegion WHERE CityID=" + idCity.ToString();
            SqlDataAdapter dataAdapter_Regions = new SqlDataAdapter(sqlString, connection);
            dataAdapter_Regions.Fill(dataSet_Regions, "RegionName");

            List<String> list = new List<String>();

            foreach (DataRow row in dataSet_Regions.Tables["RegionName"].Rows)
            {

                list.Add(row.ItemArray.GetValue(2).ToString());

            }

            sqlConnection.Close();

            return list;
        }

        [WebMethod]
        public bool checkUserName(String name)
        {
            bool success = false;
            String sqlStatement = "Select * from dbo.Users where UserName = @name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 15).Value = name;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        success = true;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            return success;
        }

        [WebMethod]
        public bool checkUser(String name, String password)
        {
            bool success = false;
            String sqlStatement = "Select * from dbo.Users where UserName = @name and Password = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 25).Value = name;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 25).Value = password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        success = true;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            return success;
        }

        [WebMethod]
        public List<String> getUser(String name)
        {

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            string query = "SELECT * FROM Users where UserName = @name";

            List<string> user = new List<string>();


            myCon.Open();

            SqlCommand cmd = new SqlCommand(query, myCon);
            cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 15).Value = name;
            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                user.Add(dataReader["UserName"].ToString());
                user.Add(dataReader["FirstName"].ToString());
                user.Add(dataReader["LastName"].ToString());
                user.Add(dataReader["PhoneNumber"].ToString());
                user.Add(dataReader["Email"].ToString());
                user.Add(dataReader["Password"].ToString());
            }

            dataReader.Close();

            myCon.Close();

            return user;
        }

        [WebMethod]
        public bool checkParkingPlace(string parkingPlaceName)
        {
            bool success = false;
            String sqlStatement = "Select * from dbo.ParkingPlaces where ParkPlaceName = @parkingPlaceName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@parkingPlaceName", System.Data.SqlDbType.VarChar, 15).Value = parkingPlaceName;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        success = true;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            return success;
        }

        [WebMethod]
        public void addUser(String userName, String firstName, String lastName, String email, String phoneNr, String password)
        {
            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("Insert into Users (UserName,FirstName,LastName,PhoneNumber,Email,Password)" +
                    " values (@userName,@firstName,@lastName,@phoneNumber,@email,@password)", myCon);
                command.Parameters.Add("@userName", SqlDbType.Text).Value = userName;
                command.Parameters.Add("@firstName", SqlDbType.Text).Value = firstName;
                command.Parameters.Add("@lastName", SqlDbType.Text).Value = lastName;
                command.Parameters.Add("@phoneNumber", SqlDbType.Text).Value = phoneNr;
                command.Parameters.Add("@email", SqlDbType.Text).Value = email;
                command.Parameters.Add("@password", SqlDbType.Text).Value = password;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            myCon.Close();
        }

        [WebMethod]
        public bool CityExists(String name)
        {
            name = name.ToUpper();
            bool success = false;
            String sqlStatement = "Select * from dbo.City where CityName = @name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@name", System.Data.SqlDbType.NChar, 25).Value = name;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        success = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return success;
        }

        [WebMethod]
        public bool RegionExists(String name,int cityId)
        {
            name = name.ToUpper();
            bool success = false;
            String sqlStatement = "Select * from CityRegion where RegionName = @name and CityID = @cityId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@name", name);
                command.Parameters.Add("@cityId", cityId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        success = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return success;
        }
        [WebMethod]
        public bool ParkingPlaceExists(String name,int regionId)
        {
            name = name.ToUpper();
            bool success = false;
            String sqlStatement = "Select * from ParkingPlaces where ParkPlaceName = @name and RegionID = @regionId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@name", name);
                command.Parameters.Add("@regionId", regionId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        success = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return success;
        }

        

        [WebMethod]
        public int getCityId(String name)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            string query = "SELECT CityID FROM City WHERE CityName = @name";

            int id = -1;


            myCon.Open();

            SqlCommand cmd = new SqlCommand(query, myCon);
            cmd.Parameters.Add("name", name);

            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader["CityID"].ToString());
            }

            dataReader.Close();

            myCon.Close();

            return id;

        }

        [WebMethod]
        public int getRegionId(String name)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            string query = "SELECT RegionID FROM CityRegion WHERE RegionName = @name";

            int id = -1;

            myCon.Open();

            SqlCommand cmd = new SqlCommand(query, myCon);
            cmd.Parameters.Add("name", name);

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader["RegionID"].ToString());
            }

            dataReader.Close();

            myCon.Close();

            return id;

        }

        [WebMethod]
        public Boolean deleteParkPlace(string name)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;
            try
            {
                using (myCon)
                {
                    myCon.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM ParkingPlaces WHERE ParkPlaceName = @name", myCon);
                    command.Parameters.Add("@name", name);

                    using (command)
                    {
                        command.ExecuteNonQuery();
                    }

                    myCon.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            };
        }

        [WebMethod]
        public Boolean deleteRegion(string name)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;
            try
            {
                using (myCon)
                {
                    myCon.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM CityRegion WHERE RegionName = @name", myCon);
                    command.Parameters.Add("@name", name);

                    using (command)
                    {
                        command.ExecuteNonQuery();
                    }

                    myCon.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            };
        }
        [WebMethod]
        public Boolean deleteCity(string name)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;
            try
            {
                using (myCon)
                {
                    myCon.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM City WHERE CityName = @name", myCon);
                    command.Parameters.Add("@name", name);

                    using (command)
                    {
                        command.ExecuteNonQuery();
                    }

                    myCon.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            };
        }

        [WebMethod]
        public List<String> getRegionsForCity(int cityId)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            string query = "SELECT RegionName FROM CityRegion WHERE CityID = @cityId";

            List<string> regions = new List<string>();


            myCon.Open();

            SqlCommand cmd = new SqlCommand(query, myCon);
            cmd.Parameters.Add("cityId", cityId);

            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                regions.Add(dataReader["RegionName"].ToString());
            }

            dataReader.Close();

            myCon.Close();

            return regions;
        }

        [WebMethod]
        public List<String> getParkPlacesForRegion(int regionId)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            string query = "SELECT ParkPlaceName FROM ParkingPlaces WHERE CityRegionID = @regionId";

            List<string> parkPlaces = new List<string>();


            myCon.Open();

            SqlCommand cmd = new SqlCommand(query, myCon);
            cmd.Parameters.Add("regionId", regionId);

            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                parkPlaces.Add(dataReader["ParkPlaceName"].ToString());
            }

            dataReader.Close();

            myCon.Close();

            return parkPlaces;
        }

        [WebMethod]

        public Boolean changeCityName(String oldName, String newName)
        {

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("Update City Set CityName = @newName where CityName = @oldName", myCon);

                command.Parameters.Add("@oldName", SqlDbType.NChar).Value = oldName;
                command.Parameters.Add("@newName", SqlDbType.NChar).Value = newName;
                command.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                myCon.Close();
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        [WebMethod]
        public Boolean changeRegionName(String oldName, String newName)
        {

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("Update CityRegion Set RegionName = @newName where RegionName = @oldName", myCon);

                command.Parameters.Add("@oldName", SqlDbType.NChar).Value = oldName;
                command.Parameters.Add("@newName", SqlDbType.NChar).Value = newName;
                command.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                myCon.Close();
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        [WebMethod]
        public Boolean changeParkPlace(String oldName, String newName, int newSpaces)
        {

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("Update ParkingPlaces Set ParkPlaceName = @newName,NrSpaces = @newSpaces where ParkPlaceName = @oldName", myCon);

                command.Parameters.Add("@oldName", SqlDbType.NChar).Value = oldName;
                command.Parameters.Add("@newName", SqlDbType.NChar).Value = newName;
                command.Parameters.Add("@newSpaces", SqlDbType.NChar).Value = newSpaces;
                command.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                myCon.Close();
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        [WebMethod]
        public int getNrSpaces(String name)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            string query = "SELECT NrSpaces FROM ParkingPlaces WHERE ParkPlaceName = @name";
            int nrSpaces = 0;
            myCon.Open();
            SqlCommand cmd = new SqlCommand(query, myCon);
            cmd.Parameters.Add("name", name);

            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                nrSpaces = Convert.ToInt32(dataReader["NrSpaces"].ToString());
            }

            dataReader.Close();

            myCon.Close();

            return nrSpaces;
        }

        [WebMethod]
        public Boolean sendEmail(String email,String msg, String userName, String firstName, String lastName, String phoneNr)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("ropark.mail@gmail.com", "aagvxllfrllyrare");

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress("ropark.mail@gmail.com");
                mailDetails.To.Add(email);
                mailDetails.Subject = "ROPark";
                mailDetails.IsBodyHtml = false;
                mailDetails.Body = msg;
                client.Send(mailDetails);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        [WebMethod]
        public Boolean addCity(String cityName,int mapx,int mapy)
        {
            
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("Insert into City (CityName,MapX,MapY) values (@name,@mapx,@mapy)", myCon);
                command.Parameters.Add("@name", SqlDbType.NChar).Value = cityName;
                command.Parameters.Add("@mapx", SqlDbType.Int).Value = mapx;
                command.Parameters.Add("@mapy", SqlDbType.Int).Value = mapy;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                myCon.Close();
            }
        }

  

        [WebMethod]
        public Boolean addParkingPlace(int regionId, String name, int nrSpaces)
        {

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("Insert into ParkingPlaces (CityRegionID,ParkPlaceName,NrSpaces) values (@regionId,@name,@nrSpaces)", myCon);
                command.Parameters.Add("@regionId", SqlDbType.Int).Value = regionId;
                command.Parameters.Add("@name", SqlDbType.NChar).Value = name;
                command.Parameters.Add("@nrSpaces", SqlDbType.Int).Value = nrSpaces;

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                myCon.Close();
            }
        }

        [WebMethod]
        public Boolean addRegion(int cityId, String name)
        {

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("Insert into CityRegion (CityID,RegionName) values (@cityId,@name)", myCon);
                command.Parameters.Add("@cityId", SqlDbType.Int).Value = cityId;
                command.Parameters.Add("@name", SqlDbType.NChar).Value = name;

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                myCon.Close();
            }
        }

        [WebMethod]
        public List<History> getAllHistory()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataSet dataSet_History = new DataSet();
            SqlDataAdapter dataAdapter_History = new SqlDataAdapter("SELECT * FROM History", connection);
            DataTable dtHistory = new DataTable();
            dataAdapter_History.Fill(dataSet_History, "History");

            List<History> list = new List<History>();

            foreach (DataRow row in dataSet_History.Tables["History"].Rows)
            {

                History history = new History();
                history.historyId = Convert.ToInt32(row.ItemArray.GetValue(0));
                history.userId = Convert.ToInt32(row.ItemArray.GetValue(1));
                history.PlateNr = row.ItemArray.GetValue(2).ToString();
                history.parkingLotId = Convert.ToInt32(row.ItemArray.GetValue(3));
                history.parkingPlaceId = Convert.ToInt32(row.ItemArray.GetValue(4));
                history.regionId = Convert.ToInt32(row.ItemArray.GetValue(5));
                history.cityId = Convert.ToInt32(row.ItemArray.GetValue(6));
                history.date = Convert.ToDateTime(row.ItemArray.GetValue(7));

                list.Add(history);

            }


            sqlConnection.Close();

            return list;
        }

        [WebMethod]
        public String getUserById(int id)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            String query = "SELECT UserName FROM Users WHERE UserID = @id";
            String username = null;
            myCon.Open();

            SqlCommand cmd = new SqlCommand(query, myCon);
            cmd.Parameters.Add("id", id);

            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                username = dataReader["UserName"].ToString();
            }

            dataReader.Close();

            myCon.Close();

            return username;
        }


        [WebMethod]
        public String getParkPlaceById(int id)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            String query = "SELECT ParkPlaceName FROM ParkingPlaces WHERE ParkingPlaceID = @id";
            String username = null;
            myCon.Open();

            SqlCommand cmd = new SqlCommand(query, myCon);
            cmd.Parameters.Add("id", id);

            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                username = dataReader["ParkPlaceName"].ToString();
            }

            dataReader.Close();

            myCon.Close();

            return username;
        }

        [WebMethod]
        public String getRegionById(int id)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = connectionString;

            String query = "SELECT RegionName FROM CityRegion WHERE RegionID = @id";
            String username = null;
            myCon.Open();

            SqlCommand cmd = new SqlCommand(query, myCon);
            cmd.Parameters.Add("id", id);

            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                username = dataReader["RegionName"].ToString();
            }

            dataReader.Close();

            myCon.Close();

            return username;
        }
    }


}
