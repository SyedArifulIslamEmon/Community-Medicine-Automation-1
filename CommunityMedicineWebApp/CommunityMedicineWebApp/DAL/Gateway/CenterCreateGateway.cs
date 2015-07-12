using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class CenterCreateGateway
    {
        private string connectionstring = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();

        public int Save(CenterCreate aCenterCreate)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "insert into tbl_CenterCreate values ('" + aCenterCreate.Name + "','" + aCenterCreate.ThanaID + "','" + aCenterCreate.DistrictID + "','" + aCenterCreate.Code + "','" + aCenterCreate.Password + "')";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public int GetIDByThanaName(string thana)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select ID from tbl_Thana where ThanaName = '" + thana + "'";
            SqlCommand command = new SqlCommand(query,connection);
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

        public int GetDistrictIDByThanaName(string thana)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select DistrictID from tbl_Thana where ThanaName = '" + thana + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader["DistrictID"].ToString());
            }
            reader.Close();
            connection.Close();
            return id;
        }

        public List<CenterCreate> CenterList(string thana)
        {
            int thanaID = GetThanaIDByThana(thana);

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select * from tbl_CenterCreate where ThanaID = '"+thanaID+"'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<CenterCreate> centerList = new List<CenterCreate>();
            while (reader.Read())
            {
                CenterCreate aCenterCreate = new CenterCreate();
                aCenterCreate.ID = int.Parse(reader["ID"].ToString());
                aCenterCreate.Name = reader["Name"].ToString();
                centerList.Add(aCenterCreate);
            }
            reader.Close();
            connection.Close();
            return centerList;
        }
        public int GetThanaIDByThana(string thana)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select ID from tbl_Thana where ThanaName = '" + thana+ "'";
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


        public int Login(string code, string password)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select * from tbl_CenterCreate where Code = '" + code + "' and Password = '" + password +"'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int count = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count++;
            }
            reader.Close();
            connection.Close();
            return count;
        }

        public string GetCenterByCode(string code)
        {
            string Center = string.Empty;

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select Name from tbl_CenterCreate where Code = '" + code + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                 Center = reader["Name"].ToString();

            }
            reader.Close();
            connection.Close();
            return Center;
        }

        public string GetThanaByCode(string code)
        {
            string Thana = string.Empty;
            int thanaID = GetThanaIDByCode(code);

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select ThanaName from tbl_Thana where ID = '" + thanaID + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Thana = reader["ThanaName"].ToString();

            }
            reader.Close();
            connection.Close();
            return Thana;
        }

        public int GetThanaIDByCode(string code)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select ThanaID from tbl_CenterCreate where Code = '" + code + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader["ThanaID"].ToString());
            }
            reader.Close();
            connection.Close();
            return id;
        }

        public string GetDistrictByCode(string code)
        {
            string District = string.Empty;
            int districtID = GetDistrictIDByCode(code);

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select DistrictName from tbl_District where ID = '" + districtID + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                District = reader["DistrictName"].ToString();

            }
            reader.Close();
            connection.Close();
            return District;
        }
        public int GetDistrictIDByCode(string code)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select DistrictID from tbl_CenterCreate where Code = '" + code + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader["DistrictID"].ToString());
            }
            reader.Close();
            connection.Close();
            return id;
        }
    }
}