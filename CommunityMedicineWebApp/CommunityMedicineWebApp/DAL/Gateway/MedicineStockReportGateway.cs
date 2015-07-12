using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class MedicineStockReportGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();

        public List<SendMedicine> MedicineList(int district, int thana, int center)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query ="select MedicineName, Quantity from tbl_SendMedicine where DistrictID = '"+district+"' and ThanaID = '"+thana+"' and Center = '"+center+"'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<SendMedicine> medicines = new List<SendMedicine>();
            while (reader.Read())
            {
                SendMedicine aMedicine = new SendMedicine();
                aMedicine.Medicine = reader["MedicineName"].ToString();
                aMedicine.Quantity = int.Parse(reader["Quantity"].ToString());
                medicines.Add(aMedicine);
            }
            reader.Close();
            connection.Close();
            return medicines;
        }

        public int GetIDByDistrictName(string districtName)
        {
            int id =0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ID from tbl_District where DistrictName = '"+districtName+"'";
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

        public int GetIDByThanaName(string thanaName)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ID from tbl_Thana where ThanaName = '" + thanaName + "'";
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

        public int GetIDByCenterName(string centerName)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ID from tbl_centerCreate where Name = '" + centerName + "'";
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