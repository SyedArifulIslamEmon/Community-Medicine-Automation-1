using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicineWebApp.BLL;

namespace CommunityMedicineWebApp.UI
{
    public partial class MedicineStockReport : System.Web.UI.Page
    {
        MedicineStockReportManager aManager = new MedicineStockReportManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            string center = Session["Center"].ToString();
            string thana = Session["Thana"].ToString();
            string district = Session["District"].ToString();
            centerLabel.Text = center + ", " + thana + ", " + district;

            int districtID = aManager.GetIDByDistrictName(district);
            int thanaID = aManager.GetIDByThanaName(thana);
            int centerID = aManager.GetIDByCenterName(center);

            medicineGridView.AutoGenerateColumns = false;
            medicineGridView.DataSource = aManager.MedicineList(districtID,thanaID,centerID);
            medicineGridView.DataBind();
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["Center"] = null;
            Session["Thana"] = null;
            Session["District"] = null;
            Response.Redirect("CenterLoginUI.aspx");
        }

        protected void menuButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CenterMenu.aspx");
        }
    }
}