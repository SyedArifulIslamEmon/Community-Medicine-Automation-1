using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineWebApp.DAL.DAO;
using CommunityMedicineWebApp.DAL.Gateway;

namespace CommunityMedicineWebApp.BLL
{
    public class ShowAllHistoryManager
    {
        ShowAllHistoryGateway allHistoryGateway = new ShowAllHistoryGateway();

        public List<TreatmentGiven> LoadGeneralData(string voterID, int totalService)
        {
            return allHistoryGateway.LoadGeneralData(voterID,totalService);
        }

        public List<TreatmentGiven> LoadGriddata(string voterID, int serviceNumber)
        {
            return allHistoryGateway.LoadGriddata(voterID,serviceNumber);
        }

        public int GetServiceNumber(string voterID)
        {
            return allHistoryGateway.GetServiceNumber(voterID);
        }

        public string GetCenterNameByID(int id)
        {
            return allHistoryGateway.GetCenterNameByID(id);
        }
    }
}