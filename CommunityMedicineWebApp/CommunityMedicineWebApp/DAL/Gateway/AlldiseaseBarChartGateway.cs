using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class AlldiseaseBarChartGateway
    {
        TreatmentGivenGateway aGivenGateway = new TreatmentGivenGateway();

        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();

        public List<string> DiseaseList(string from, string to, int districtId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select Disease from tbl_treatmentGiven where Date >= '" + from + "' and Date <= '" + to +"' and DistrictID = '" + districtId + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            List<string> diseaseList = new List<string>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                diseaseList.Add(reader["Disease"].ToString());
            }
            reader.Close();
            connection.Close();
            return diseaseList;
        }

        public List<DiseaseChart> DiseaseForChart(string from, string to, int districtId)
        {
            List<string> calculateDisease = DiseaseList(from, to, districtId);
            List<Disease> getallDiseases = aGivenGateway.LoaDiseases();
            List<DiseaseChart> diseasechartList = new List<DiseaseChart>();

            foreach (Disease getallDisease in getallDiseases)
            {
                int count = 0;
                string name = string.Empty;

                DiseaseChart aChart = new DiseaseChart();

                foreach (string s in calculateDisease)
                {
                    

                    if (getallDisease.diseaseName.Equals(s))
                    {
                        name = s;
                        count++;
                    }
                }

                aChart.DiseaseName = name;
                aChart.AffectedPeople = count;
                diseasechartList.Add(aChart);

            }

            return diseasechartList;
        }
    }
}