using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityMedicineWebApp.DAL.DAO
{
    [Serializable]
    public class MedicineQuantity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }    
    }
}