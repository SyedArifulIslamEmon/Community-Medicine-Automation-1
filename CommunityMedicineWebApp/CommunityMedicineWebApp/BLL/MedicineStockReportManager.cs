using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    public class MedicineStockReportManager
    {
        MedicineStockReportGateway aMedicineStockReportGateway = new MedicineStockReportGateway();

        public List<SendMedicine> MedicineList(int district, int thana, int center)
        {
           return aMedicineStockReportGateway.MedicineList(district, thana, center);
        }

        public int GetIDByDistrictName(string districtName)
        {
            return aMedicineStockReportGateway.GetIDByDistrictName(districtName);
        }

        public int GetIDByThanaName(string thanaName)
        {
            return aMedicineStockReportGateway.GetIDByThanaName(thanaName);
        }

        public int GetIDByCenterName(string centerName)
        {
            return aMedicineStockReportGateway.GetIDByCenterName(centerName);
        }
    }
}