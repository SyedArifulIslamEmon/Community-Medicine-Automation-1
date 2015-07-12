using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class TreatmentGivenGateway
    {
        MedicineGateway aMedicineGateway = new MedicineGateway();

        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();
        
        public List<DoctorEntry> LoadDoctor(string center, string thana, string district)
        {
            int centerID = aMedicineGateway.GetIDByCenterName(center);
            int thanaID = aMedicineGateway.GetIDByThanaName(thana);
            int districtID = aMedicineGateway.GetIDByDistrictName(district);

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_DoctorEntry where CenterID = '" + centerID + "' and ThanaID = '" + thanaID +"' and DistrictID = '" + districtID + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            List<DoctorEntry> doctorList = new List<DoctorEntry>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DoctorEntry aDoctorEntry = new DoctorEntry();
                aDoctorEntry.ID = int.Parse(reader["ID"].ToString());
                aDoctorEntry.Name = reader["Name"].ToString();
                doctorList.Add(aDoctorEntry);
            }
            reader.Close();
            connection.Close();
            return doctorList;
        }

        public List<Disease> LoaDiseases()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_Disease_Entry";
            SqlCommand command = new SqlCommand(query, connection);
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

        public List<SendMedicine> LoadMedicines(string center, string thana, string district)
        {


            int centerID = aMedicineGateway.GetIDByCenterName(center);
            int thanaID = aMedicineGateway.GetIDByThanaName(thana);
            int districtID = aMedicineGateway.GetIDByDistrictName(district);

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_SendMedicine where Center = '" + centerID + "' and ThanaID = '" + thanaID + "' and DistrictID = '" + districtID + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            List<SendMedicine> medicineList = new List<SendMedicine>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SendMedicine aMedicine = new SendMedicine();
                aMedicine.ID = int.Parse(reader["ID"].ToString());
                aMedicine.Medicine = reader["MedicineName"].ToString();
                medicineList.Add(aMedicine);
            }
            reader.Close();
            connection.Close();
            return medicineList;
        }

        public List<Dose> LoaDoses()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_Dose";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Dose> doseList = new List<Dose>();
            while (reader.Read())
            {
                Dose aDose = new Dose();
                aDose.ID = int.Parse(reader["ID"].ToString());
                aDose.DoseName = reader["Dose"].ToString();
                doseList.Add(aDose);
            }
            reader.Close();
            connection.Close();
            return doseList;
        }

        public int GetServiceNumber(string voterID)
        {
            if (IsVoterExist(voterID))
            {
                return PreviousServiceNumber(voterID);
            }
            else
            {
                return 0;
            }
        }

        public bool IsVoterExist(string voterID)
        {
           
            bool isVoterExist = false;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_TreatmentGiven where VoterID = '" + voterID + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isVoterExist = true;
            }
            reader.Close();
            connection.Close();
            return isVoterExist;
        }

        public int PreviousServiceNumber(string voterID)
        {
            int previousService = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ServiceGiven from tbl_TreatmentGiven where VoterID = '" + voterID + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                previousService = int.Parse(reader["ServiceGiven"].ToString());
            }
            reader.Close();
            connection.Close();
            return previousService;
        }

        public int SaveTreatmentGiven(TreatmentGiven aTreatmentGiven)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into tbl_TreatmentGiven values ('"+aTreatmentGiven.VoterID+"','"+aTreatmentGiven.ServiceGiven+"','"+aTreatmentGiven.Observation+"','"+aTreatmentGiven.Date+"','"+aTreatmentGiven.Doctor+"','"+aTreatmentGiven.Disease+"','"+aTreatmentGiven.Medicine+"','"+aTreatmentGiven.Dose+"','"+aTreatmentGiven.Meal+"','"+aTreatmentGiven.Quantity+"','"+aTreatmentGiven.Note+"','"+aTreatmentGiven.CenterID+"','"+aTreatmentGiven.ThanaID+"','"+aTreatmentGiven.DistrictID+"')";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        
    }
}