using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace CommunityMedicineWebApp.DAL.DAO
{
     [Serializable]
    public class TreatmentGiven
    {
        public int ID { get; set; }
        public string VoterID { get; set; }
        //public string Name { get; set; }
        //public string Address { get; set; }
        //public string Age { get; set; }
        public int ServiceGiven { get; set; }
        public string Observation { get; set; }
        public string Date { get; set; }
        public string Doctor { get; set; }
        public string Disease { get; set; }
        public string Medicine { get; set; }
        public string Dose { get; set; }
        public string Meal { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
         public int CenterID { get; set; }
         public int ThanaID { get; set; }
         public int DistrictID { get; set; }


    }
}