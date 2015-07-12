using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class DiseaseEntryGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();
        public int saveDiseaseEntry(Disease aDisease)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into tbl_Disease_Entry values('" + aDisease.diseaseName + "','"+aDisease.diseaseDescription+"','"+aDisease.diseaseTreatment+"','"+aDisease.diseaseProcedure+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }
        public bool IsDiseaseNameExists(Disease aDisease)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Disease_Entry WHERE DiseaseName='" + aDisease.diseaseName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            bool isDiseaseNameExists = false;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isDiseaseNameExists = true;
            }
            reader.Close();
            connection.Close();

            return isDiseaseNameExists;
        }
        public List<Disease> LoadAllDiseasesName()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Disease_Entry";
            SqlCommand command = new SqlCommand(query, connection);
            List<Disease> diseaseEntryList = new List<Disease>();

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                Disease aDisease=new Disease();

                aDisease.id = serial;

                aDisease.diseaseName = reader["DiseaseName"].ToString();
                aDisease.diseaseDescription = reader["DiseaseDescription"].ToString();
                aDisease.diseaseTreatment = reader["DiseaseTreatment"].ToString();
                aDisease.diseaseProcedure = reader["DiseaseProcedure"].ToString();


                diseaseEntryList.Add(aDisease);
                serial++;
            }
            reader.Close();
            connection.Close();

            return diseaseEntryList;
        }
    }
}