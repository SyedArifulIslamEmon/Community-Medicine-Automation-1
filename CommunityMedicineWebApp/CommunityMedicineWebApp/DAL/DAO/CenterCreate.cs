using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityMedicineWebApp.DAL.DAO
{
    public class CenterCreate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DistrictID { get; set; }
        public int ThanaID { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
    }
}