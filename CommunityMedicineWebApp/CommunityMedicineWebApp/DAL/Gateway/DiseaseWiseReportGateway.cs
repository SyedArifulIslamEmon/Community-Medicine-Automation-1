using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class DiseaseWiseReportGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();
        public List<Disease> LoadDiseases()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_Disease_Entry";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            List<Disease> diseaseList = new List<Disease>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Disease aDisease = new Disease();
                aDisease.id = int.Parse(reader["ID"].ToString());
                aDisease.diseaseName = reader["DiseaseName"].ToString();
                diseaseList.Add(aDisease);
            }
            reader.Close();
            connection.Close();
            return diseaseList;
        }

        public List<TreatmentGiven> DiseaseWiseList(string fromdate, string todate, string diseaseName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select DistrictID, VoterID, Disease  from tbl_TreatmentGiven where Date >= '" + fromdate + "' and Date <= '" + todate + "' and Disease = '" + diseaseName + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            List<TreatmentGiven> diseaseWisesList = new List<TreatmentGiven>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TreatmentGiven aTreatmentGiven = new TreatmentGiven();
                aTreatmentGiven.DistrictID = int.Parse(reader["DistrictID"].ToString());
                aTreatmentGiven.VoterID = reader["VoterID"].ToString();
                diseaseWisesList.Add(aTreatmentGiven);
            }
            reader.Close();
            connection.Close();
            return diseaseWisesList;
        }

        public string GetDistrictByID(int id)
        {
            string districtName = string.Empty;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select DistrictName from tbl_District where ID = '" + id + "'";
            SqlCommand  command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                districtName = reader["DistrictName"].ToString();
            }
            reader.Close();
            connection.Close();
            return districtName;
        }

        public int NumberofPatient(int id, string from, string to, string disease)
        {
            int count = 0;

            List<TreatmentGiven> patientNumberList = DiseaseWiseList(from, to, disease);
            foreach (TreatmentGiven given in patientNumberList)
            {
                if (given.DistrictID == id)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetTotalPopulationOfDistrict(int id)
        {
            int totalPopulation = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select Population from tbl_District where ID = '" + id + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                totalPopulation = int.Parse(reader["Population"].ToString());

            }
            reader.Close();
            connection.Close();
            return totalPopulation;
        }
        public List<DiseaseWise> getreportInfoList(string fromdate, string todate, string diseaseName)
        {
            List<TreatmentGiven> calculateList = DiseaseWiseList(fromdate, todate, diseaseName);
            List<DiseaseWise> reportList = new List<DiseaseWise>();
            int count = 0;

            foreach (TreatmentGiven aTreatementGiven in calculateList)
            {
                int id = aTreatementGiven.DistrictID;

                if (NumberofPatient(id, fromdate, todate, diseaseName)>1 && (count!=1))
                {
                    DiseaseWise aDiseaseWise = new DiseaseWise();
                    int disId = aTreatementGiven.DistrictID;
                    string disName = GetDistrictByID(disId);
                    aDiseaseWise.Name = disName;
                    aDiseaseWise.NumberOfPatient = NumberofPatient(disId, fromdate, todate, diseaseName);
                    int over = (aDiseaseWise.NumberOfPatient*100)/GetTotalPopulationOfDistrict(disId);
                    aDiseaseWise.OverPopulation = over;
                    reportList.Add(aDiseaseWise);
                    count = 1;
                }
                if (NumberofPatient(id, fromdate, todate, diseaseName) == 1)
                {
                    DiseaseWise aDiseaseWise = new DiseaseWise();
                    int disId = aTreatementGiven.DistrictID;
                    string disName = GetDistrictByID(disId);
                    aDiseaseWise.Name = disName;
                    aDiseaseWise.NumberOfPatient = 1;
                    int over = (aDiseaseWise.NumberOfPatient * 100) / GetTotalPopulationOfDistrict(disId);
                    aDiseaseWise.OverPopulation = over;
                    reportList.Add(aDiseaseWise);
                }
                
            }
            return reportList;
        }
    }
}