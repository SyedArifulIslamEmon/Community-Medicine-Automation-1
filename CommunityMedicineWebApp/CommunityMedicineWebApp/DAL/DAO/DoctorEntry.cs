using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityMedicineWebApp.DAL.DAO
{
    public class DoctorEntry
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Degeree { get; set; }
        public string Specialization { get; set; }
        public int CenterID { get; set; }
        public int ThanaID { get; set; }
        public int DistrictID { get; set; }
    }
}