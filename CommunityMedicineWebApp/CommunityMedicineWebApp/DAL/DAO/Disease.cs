using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityMedicineWebApp.DAL.DAO
{
    public class Disease
    {
        public int id { get; set; }
        public string diseaseName { get; set; }
        public string diseaseDescription { get; set; }
        public string diseaseTreatment { get; set; }
        public string diseaseProcedure { get; set; }
    }
}