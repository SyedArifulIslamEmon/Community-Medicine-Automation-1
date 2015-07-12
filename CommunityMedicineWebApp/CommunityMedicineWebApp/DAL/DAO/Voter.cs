using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityMedicineWebApp.DAL.DAO
{
    public class Voter
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string date_of_birth { get; set; }
    }
}