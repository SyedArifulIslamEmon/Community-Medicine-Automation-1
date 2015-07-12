using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using CommunityMedicineWebApp.BLL;
using System.Collections.Generic;

namespace CommunityMedicineWebApp.UI
{
    public partial class AlldiseasesBarChart : System.Web.UI.Page
    {
        AlldiseaseBarChartManager aManager = new AlldiseaseBarChartManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                districtDropDownList.DataSource = aManager.LoadAllDistrict();
                districtDropDownList.DataTextField = "DistrictName";
                districtDropDownList.DataValueField = "ID";
                districtDropDownList.DataBind();
            }
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            

            diseaseChart.Series["Series1"].XValueMember = "DiseaseName";
            diseaseChart.Series["Series1"].YValueMembers = "AffectedPeople";
            diseaseChart.DataSource = aManager.DiseaseForChart(firstDateTextBox.Text, secondDateTextBox.Text, int.Parse(districtDropDownList.SelectedValue));
            diseaseChart.DataBind();

        }

        protected void menuButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CenterMenu.aspx");
        }
    }
}