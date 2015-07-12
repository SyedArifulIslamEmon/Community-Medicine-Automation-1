using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    public class TreatmentGivenManager
    {
        TreatmentGivenGateway aTreatmentGivenGateway = new TreatmentGivenGateway();
        MedicineGateway aMedicineGateway = new MedicineGateway();

        public List<DoctorEntry> LoadDoctor(string center, string thana, string district)
        {
            return aTreatmentGivenGateway.LoadDoctor(center, thana, district);
        }

        public List<Disease> LoaDiseases()
        {
            return aTreatmentGivenGateway.LoaDiseases();
        }

        public List<SendMedicine> LoadMedicines(string center, string thana, string district)
        {
            return aTreatmentGivenGateway.LoadMedicines(center, thana, district);
        }

        public List<Dose> LoaDoses()
        {
            return aTreatmentGivenGateway.LoaDoses();
        }

        public int GetServiceNumber(string voterID)
        {
           return aTreatmentGivenGateway.GetServiceNumber(voterID);
        }

        public int GetIDByCenter(string center)
        {
            return aMedicineGateway.GetIDByCenterName(center);
        }

        public int GetIDByThanaName(string thana)
        {
            return aMedicineGateway.GetIDByThanaName(thana);
        }

        public int GetIDByDistrictName(string district)
        {
            return aMedicineGateway.GetIDByDistrictName(district);
        }

        public int SaveTreatmentGiven(TreatmentGiven aTreatmentGiven)
        {
           return aTreatmentGivenGateway.SaveTreatmentGiven(aTreatmentGiven);
        }
    }
}