using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommunityMedicineWebApp.UI
{
    public partial class AfterLoginMenuUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Center"] != null && Session["Thana"] != null && Session["District"] != null)
            {
                centerLabel.Text = Session["Center"].ToString();
                thanaLabel.Text = Session["Thana"].ToString();
                DistrictLabel.Text = Session["District"].ToString();
            }
            else
            {
                Response.Redirect("CenterLoginUI.aspx");
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["Center"] = null;
            Session["Thana"] = null;
            Session["District"] = null;
            Response.Redirect("CenterLoginUI.aspx");
        }

        protected void doctorEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoctorEntryUI.aspx");
        }

        protected void treatmentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TreatmentGivenUI.aspx");
        }

        protected void stockReportButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MedicineStockReport.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DiseaseWiseReportUI.aspx");
        }

        protected void allDiseaseButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AlldiseasesBarChart.aspx");
        }

        protected void demographicButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DiseaseDemogReport.aspx");
        }
    }
}