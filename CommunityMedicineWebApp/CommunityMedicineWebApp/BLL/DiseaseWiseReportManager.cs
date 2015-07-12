using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    
    public class DiseaseWiseReportManager
    {
        DiseaseWiseReportGateway aDiseaseWiseReportGateway = new DiseaseWiseReportGateway();

        public List<Disease> LoadDiseases()
        {
            return aDiseaseWiseReportGateway.LoadDiseases();
        }

        public List<DiseaseWise> getreportInfoList(string fromdate, string todate, string diseaseName)
        {
            return aDiseaseWiseReportGateway.getreportInfoList(fromdate, todate, diseaseName);
        }
    }
}