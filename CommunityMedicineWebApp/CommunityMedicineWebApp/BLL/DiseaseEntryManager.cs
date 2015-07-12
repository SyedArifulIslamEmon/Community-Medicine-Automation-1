using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    public class DiseaseEntryManager
    {
        DiseaseEntryGateway aDiseaseEntryGateway=new DiseaseEntryGateway();
        public string SavediseaseEntry(Disease aDisease)
        {
            if (aDiseaseEntryGateway.IsDiseaseNameExists(aDisease))
            {
                return "Disease Name Already Exists";
            }
            else if (aDiseaseEntryGateway.saveDiseaseEntry(aDisease) > 0)
            {
                return "Disease Name Saved Successfully";
            }
            else
            {
                return "Disease name Not Saved Correctly";
            }
        }

        public List<Disease> LoadAllDiseasesName()
        {
            return aDiseaseEntryGateway.LoadAllDiseasesName();
        } 
    }
}