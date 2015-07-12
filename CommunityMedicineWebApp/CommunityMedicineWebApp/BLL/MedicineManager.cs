using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    public class MedicineManager
    {
        MedicineGateway aGateway = new MedicineGateway();
        

        public string saveMedicine(Medicine aMedicine)
        {
            if (aGateway.IsMedicineNameExists(aMedicine))
            {
                return "Medicine Name is Already Exists";
            }
            else if(aGateway.saveMedicine(aMedicine) > 0)
            {
                return "Medicine Saved Successfully.";
            }

            else
            {
                return "Medicine not saved.";
            }
        }

        public bool isThisMedicenExist(int districtID, int thanaID, int centerID, string medicineName)
        {
            return aGateway.isThisMedicenExist(districtID, thanaID, centerID, medicineName);
        }

        public int PreviousQuantity(int districtID, int thanaID, int centerID, string medicineName)
        {
            return aGateway.PreviousQuantity(districtID, thanaID, centerID, medicineName);
        }

        public string updateQuantity(int districtID, int thanaID, int centerID, string medicineName, int currentQuantity)
        {
            if (aGateway.updateQuantity(districtID, thanaID, centerID, medicineName, currentQuantity)>0)
            {
                return medicineName + " already added in this center. Quantity updated.";
            }
            else
            {
                return "Not updated quantiry.";
            }
        }

        public List<Medicine> LoadAllMedicine()
        {
            return aGateway.LoadAllMedicine();
        }

        public int saveSendMedicine(SendMedicine aSendMedicine)
        {
            return aGateway.saveSendMedicine(aSendMedicine);
        }
        public int GetIDByDistrictName(string district)
        {
            return aGateway.GetIDByDistrictName(district);
        }

        public int GetIDByThanaName(string thana)
        {
            return aGateway.GetIDByThanaName(thana);
        }

        public int GetIDByCenterName(string center)
        {
            return aGateway.GetIDByCenterName(center);
        }
    }
}