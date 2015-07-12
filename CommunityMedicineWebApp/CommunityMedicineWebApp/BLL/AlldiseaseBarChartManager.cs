using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    public class AlldiseaseBarChartManager
    {
        DistrictGateway aDistrictGateway = new DistrictGateway();
        AlldiseaseBarChartGateway agAlldiseaseBarChartGateway = new AlldiseaseBarChartGateway();

        public List<District> LoadAllDistrict()
        {
            return aDistrictGateway.LoadAllDistrict();
        }

        public List<DiseaseChart> DiseaseForChart(string from, string to, int districtId)
        {
            return agAlldiseaseBarChartGateway.DiseaseForChart(from, to, districtId);
        }
    }
}