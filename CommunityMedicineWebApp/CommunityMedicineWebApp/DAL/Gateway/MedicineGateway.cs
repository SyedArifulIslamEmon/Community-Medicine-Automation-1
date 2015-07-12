using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class MedicineGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();
        public int saveMedicine(Medicine aMedicine)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into tbl_Medicine values('"+aMedicine.MedicineName+"')";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public bool IsMedicineNameExists(Medicine aMedicine)
        {
            SqlConnection connection=new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Medicine WHERE MedicineName='" + aMedicine.MedicineName + "'";
            SqlCommand command=new SqlCommand(query,connection);
            bool isMedicineNameExists = false;
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isMedicineNameExists = true;
            }
            reader.Close();
            connection.Close();

            return isMedicineNameExists;
        }
        public List<Medicine> LoadAllMedicine()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Medicine";
            SqlCommand command = new SqlCommand(query, connection);
            List<Medicine> medicineList=new List<Medicine>();
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                Medicine aMedicine=new Medicine();

                aMedicine.ID = serial;
                
                aMedicine.MedicineName = reader["MedicineName"].ToString();

                medicineList.Add(aMedicine);
                serial++;
            }
            reader.Close();
            connection.Close();

            return medicineList;
        }

        public int saveSendMedicine(SendMedicine aSendMedicine)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into tbl_SendMedicine values('"+aSendMedicine.DistrictID+"','"+aSendMedicine.ThanaID+"','"+aSendMedicine.CenterID+"','"+aSendMedicine.Medicine+"','"+aSendMedicine.Quantity+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public int GetIDByDistrictName(string district)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ID from tbl_District where DistrictName = '" + district + "'";
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

        public int GetIDByThanaName(string thana)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ID from tbl_Thana where ThanaName = '" + thana + "'";
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

        public int GetIDByCenterName(string center)
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ID from tbl_CenterCreate where Name = '" + center + "'";
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

        public bool isThisMedicenExist(int districtID, int thanaID, int centerID, string medicineName)
        {
            bool resutl = false;

            SqlConnection connection = new SqlConnection(connectionString);
            String query = " select * from tbl_SendMedicine where DistrictID = '"+districtID+"' and ThanaID = '"+thanaID+"' and Center = '"+centerID+"' and MedicineName = '"+medicineName+"'";
            SqlCommand command = new SqlCommand(query,connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                resutl = true;
            }
            reader.Close();
            connection.Close();
            return resutl;
        }

        public int PreviousQuantity(int districtID, int thanaID, int centerID, string medicineName)
        {
            int previousQuantity = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            String query = " select Quantity from tbl_SendMedicine where DistrictID = '" + districtID + "' and ThanaID = '" + thanaID + "' and Center = '" + centerID + "' and MedicineName = '" + medicineName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                previousQuantity = int.Parse(reader["Quantity"].ToString());
            }
            reader.Close();
            connection.Close();
            return previousQuantity;
        }

        public int updateQuantity(int districtID, int thanaID, int centerID, string medicineName, int currentQuantity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "update tbl_SendMedicine set Quantity = '" + currentQuantity + "' where DistrictID = '" +districtID + "' and ThanaID = '" + thanaID + "' and Center = '" + centerID +"' and MedicineName = '" + medicineName + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}