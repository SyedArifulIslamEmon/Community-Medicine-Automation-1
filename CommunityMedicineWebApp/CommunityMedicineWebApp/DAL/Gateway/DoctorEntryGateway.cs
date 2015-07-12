using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.DAL.Gateway
{
    public class DoctorEntryGateway
    {
        private string connectionstring = ConfigurationManager.ConnectionStrings["ConnectDB"].ToString();
        public int SaveDoctor(DoctorEntry aDoctorEntry)
        {
            SqlConnection connection     = new SqlConnection(connectionstring);
            string query = "insert into tbl_DoctorEntry values ('"+aDoctorEntry.Name+"','"+aDoctorEntry.Degeree+"','"+aDoctorEntry.Specialization+"','"+aDoctorEntry.CenterID+"','"+aDoctorEntry.ThanaID+"','"+aDoctorEntry.DistrictID+"')";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

    }
}