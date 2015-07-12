using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicineWebApp.BLL;
using CommunityMedicineWebApp.DAL.DAO;

namespace CommunityMedicineWebApp.UI
{
    public partial class DiseaseEntry : System.Web.UI.Page
    {
        Disease aDisease=new Disease();
        DiseaseEntryManager aDiseaseEntryManager=new DiseaseEntryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            diseaseEntryGridView.DataSource = aDiseaseEntryManager.LoadAllDiseasesName();
            diseaseEntryGridView.DataBind();
        }

        protected void diseaseSaveButton_Click(object sender, EventArgs e)
        {
            aDisease.diseaseName = diseaseNameTextBox.Text;
            aDisease.diseaseDescription = diseaseDescriptionTextBox.Text;
            aDisease.diseaseTreatment = diseaseTreatmentTextBox.Text;
            aDisease.diseaseProcedure = diseaseProcedureTextBox.Text;
            showLabel.Text = aDiseaseEntryManager.SavediseaseEntry(aDisease);
            diseaseEntryGridView.DataSource = aDiseaseEntryManager.LoadAllDiseasesName();
            diseaseEntryGridView.DataBind();
            diseaseNameTextBox.Text = "";
            diseaseDescriptionTextBox.Text = "";
            diseaseTreatmentTextBox.Text = "";
            diseaseProcedureTextBox.Text = "";

        }

        protected void diseaseEntryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            diseaseEntryGridView.PageIndex = e.NewPageIndex;
        }
    }
}