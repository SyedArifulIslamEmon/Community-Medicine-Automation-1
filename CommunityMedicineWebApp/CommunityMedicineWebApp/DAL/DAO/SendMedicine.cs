using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityMedicineWebApp.DAL.DAO
{
    public class SendMedicine
    {
        public int ID { get; set; }
        public int DistrictID { get; set; }
        public int ThanaID { get; set; }
        public int CenterID { get; set; }
        public string Medicine { get; set; }
        public int Quantity { get; set; }
    }
}