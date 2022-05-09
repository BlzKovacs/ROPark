using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ROPark;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
        public bool checkUser(String name,String password)
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
        public void addUser(String userName,String firstName,String lastName,String email,String phoneNr,String password)
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
        public bool checkCityDB(String name)
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

        public bool checkRegion(String name)
        {
            name = name.ToUpper();
            bool success = false;
            String sqlStatement = "Select * from dbo.CityRegion where RegionName = @name";
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

        public void addCity(string cityName)
        {
            bool exists = this.checkCityDB(cityName);
            if (exists == false)
            {
                cityName = cityName.ToUpper();
                myCon.Open();
                try
                {
                    SqlCommand command = new SqlCommand("Insert into City (CityName) values (@cityName)", myCon);
                    command.Parameters.Add("@CityName", SqlDbType.Text).Value = cityName;
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                myCon.Close();
            }
        }

        public void addRegion(string regionName, String cityName)
        {
            int cityID;
            regionName = regionName.ToUpper();
            cityName = cityName.ToUpper();

            using (myCon)
            {
                myCon.Open();
                SqlCommand cmd = new SqlCommand("Select CityID from City where CityName = @cityName", myCon);
                cmd.Parameters.Add("@cityName", SqlDbType.NChar).Value = cityName;
                cityID = (int)cmd.ExecuteScalar();

                SqlCommand command = new SqlCommand("Insert into CityRegion (CityID,RegionName) values (@cityId,@regionName)", myCon);
                command.Parameters.Add("@regionName", SqlDbType.NChar).Value = regionName;
                command.Parameters.Add("@cityID", SqlDbType.Int).Value = cityID;

                command.ExecuteNonQuery();


            }
            myCon.Close();
        }

        public void addParkingPlace(String parkPlaceName, String regionName, int nrSpaces)
        {
            int regionID;
            regionName = regionName.ToUpper();
            parkPlaceName = parkPlaceName.ToUpper();
            myCon.ConnectionString = connectionString;
            myCon.Open();
            using (myCon)
            {

                SqlCommand cmd = new SqlCommand("Select RegionID from dbo.CityRegion where RegionName = @regionName", myCon);
                cmd.Parameters.Add("@regionName", SqlDbType.NChar).Value = regionName;
                regionID = Convert.ToInt32(cmd.ExecuteScalar());

                SqlCommand command = new SqlCommand("Insert into ParkingPlaces (CityRegionID,ParkPlaceName,NrSpaces) values (@regionId,@parkPlaceName,@nrSpaces)", myCon);
                command.Parameters.Add("@parkPlaceName", SqlDbType.NChar).Value = parkPlaceName;
                command.Parameters.Add("@regionID", SqlDbType.Int).Value = regionID;
                command.Parameters.Add("@nrSpaces", SqlDbType.Int).Value = nrSpaces;

                command.ExecuteNonQuery();

            }
            myCon.Close();

        }

    }

}
