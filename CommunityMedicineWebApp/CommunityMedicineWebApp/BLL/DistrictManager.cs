using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    public class DistrictManager
    {
        DistrictGateway aDistrictGateway = new DistrictGateway();

        public List<District> LoadAllDistrict()
        {
            return aDistrictGateway.LoadAllDistrict();
        }

        public List<Thana> LoadThana(string district)
        {
           return aDistrictGateway.LoadThana(district);
        }
    }
}