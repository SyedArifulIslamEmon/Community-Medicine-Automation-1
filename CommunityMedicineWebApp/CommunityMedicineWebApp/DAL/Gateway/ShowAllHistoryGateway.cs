using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class ShowAllHistoryGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();
        
        public List<TreatmentGiven> LoadGeneralData(string voterID, int totalService)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_TreatmentGiven where VoterID = '" + voterID + "' and ServiceGiven = '"+totalService+"'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            List<TreatmentGiven> generalList = new List<TreatmentGiven>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TreatmentGiven aTreatmentGiven = new TreatmentGiven();
                aTreatmentGiven.CenterID = int.Parse(reader["CenterID"].ToString());
                aTreatmentGiven.Date = reader["Date"].ToString();
                aTreatmentGiven.Doctor = reader["Doctor"].ToString();
                aTreatmentGiven.Observation = reader["Observation"].ToString();
                aTreatmentGiven.ServiceGiven = int.Parse(reader["ServiceGiven"].ToString());
                generalList.Add(aTreatmentGiven);
            }
            reader.Close();
            connection.Close();
            return generalList;
        }

        public List<TreatmentGiven> LoadGriddata(string voterID, int serviceNumber)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_TreatmentGiven where VoterID = '" + voterID + "' and ServiceGiven = '"+serviceNumber+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            List<TreatmentGiven> generalList = new List<TreatmentGiven>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TreatmentGiven aTreatmentGiven = new TreatmentGiven();
                aTreatmentGiven.Disease = reader["Disease"].ToString();
                aTreatmentGiven.Medicine = reader["Medicine"].ToString();
                aTreatmentGiven.Dose = reader["Dose"].ToString();
                aTreatmentGiven.Meal = reader["Meal"].ToString();
                aTreatmentGiven.Quantity = int.Parse(reader["Quantity"].ToString());
                aTreatmentGiven.Note = reader["Note"].ToString();
                generalList.Add(aTreatmentGiven);
            }
            reader.Close();
            connection.Close();
            return generalList;
        }

        public int GetServiceNumber(string voterID)
        {
            int serviceNumber = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_TreatmentGiven where VoterID = '" + voterID + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                serviceNumber = int.Parse(reader["ServiceGiven"].ToString());
            }
            reader.Close();
            connection.Close();
            return serviceNumber;
        }

        public string GetCenterNameByID(int id)
        {
            string centerName = string.Empty;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select Name from tbl_CenterCreate where ID = '" + id + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                centerName = reader["Name"].ToString();
            }
            reader.Close();
            connection.Close();
            return centerName;
        }
    }
}