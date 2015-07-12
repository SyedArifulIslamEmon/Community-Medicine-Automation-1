using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    public class DoctorEntryManager
    {
        MedicineGateway aMedicineGateway = new MedicineGateway();
        DoctorEntryGateway aDoctorEntryGateway = new DoctorEntryGateway();

        public int GetIDBycenter(string center)
        {
            return aMedicineGateway.GetIDByCenterName(center);
        }

        public int GetThanaIDBythana(string thana)
        {
            return aMedicineGateway.GetIDByThanaName(thana);
        }

        public int GetIDByDistrictName(string district)
        {
            return aMedicineGateway.GetIDByDistrictName(district);
        }

        public string SaveDoctor(DoctorEntry aDoctorEntry)
        {
            if (aDoctorEntryGateway.SaveDoctor(aDoctorEntry) > 0)
            {
                return "Doctor saved successfully.";
            }
            else
            {
                return "Doctor not saved.";
            }
        }
    }
}