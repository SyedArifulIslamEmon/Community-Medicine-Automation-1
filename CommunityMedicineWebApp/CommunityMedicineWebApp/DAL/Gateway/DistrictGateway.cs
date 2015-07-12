using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class DistrictGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();
        public List<District> LoadAllDistrict()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_District";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            List<District> districtList = new List<District>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                District aDistrict = new District();
                aDistrict.ID = int.Parse(reader["ID"].ToString());
                aDistrict.DistrictName = reader["DistrictName"].ToString();
                districtList.Add(aDistrict);
            }
            reader.Close();
            connection.Close();

            return districtList;
        }

        public List<Thana> LoadThana(string district)
        {
            int districtID = GetDistrictIDByThanaName(district);

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_Thana where DistrictID = '"+districtID+"'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Thana> thanaList = new List<Thana>();
            while (reader.Read())
            {
                Thana aThana = new Thana();
                aThana.ID = int.Parse(reader["ID"].ToString());
                aThana.ThanaName = reader["ThanaName"].ToString();
                aThana.DistrictID = int.Parse(reader["DistrictID"].ToString());
                thanaList.Add(aThana);
            }
            reader.Close();
            connection.Close();

            return thanaList;
        }

        public int GetDistrictIDByThanaName(string district)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ID from tbl_District where DistrictName = '"+district+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader["ID"].ToString());
            }
            reader.Close();
            connection.Close();
            return id;
        }

        
    }
}