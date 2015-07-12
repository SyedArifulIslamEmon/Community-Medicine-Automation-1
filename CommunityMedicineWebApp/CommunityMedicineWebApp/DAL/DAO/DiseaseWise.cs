using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityMedicineWebApp.DAL.DAO
{
    public class DiseaseWise
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfPatient { get; set; }
        public int OverPopulation { get; set; }
    }
}