using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    public class CenterCreateManager
    {
        CenterCreateGateway aCenterCreateGateway = new CenterCreateGateway();

        public string Save(CenterCreate aCenterCreate)
        {
            if (aCenterCreateGateway.Save(aCenterCreate) > 0)
            {
                return "Data saved Sccessfully.";
            }
            else
            {
                return "Data not saved.";
            }
        }

        public int GetIDByThanaName(string thana)
        {
            return aCenterCreateGateway.GetIDByThanaName(thana);
        }

        public int GetDistrictIDByThanaName(string thana)
        {
            return aCenterCreateGateway.GetDistrictIDByThanaName(thana);
        }

        public List<CenterCreate> CenterList(string thana)
        {
            return aCenterCreateGateway.CenterList(thana);
        }

        public int Login(string code, string password)
        {
            return aCenterCreateGateway.Login(code, password);
        }

        public string GetCenterByCode(string code)
        {
            return  aCenterCreateGateway.GetCenterByCode(code);
        }
        public string GetThanaByCode(string code)
        {
            return aCenterCreateGateway.GetThanaByCode(code);
        }
        public string GetDistrictByCode(string code)
        {
            return aCenterCreateGateway.GetDistrictByCode(code);
        }
    }
}