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
    public partial class DoctorEntryUI : System.Web.UI.Page
    {
        DoctorEntry aDoctorEntry = new DoctorEntry();
        DoctorEntryManager aDoctorEntryManager = new DoctorEntryManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            string center = Session["Center"].ToString();
            string thana = Session["Thana"].ToString();
            string district = Session["District"].ToString();

            //ViewState["center"] = center;
            //ViewState["thana"] = thana;
            //ViewState["district"] = district;
            centerLabel.Text = center + ", " + thana + ", " + district;
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string center = Session["Center"].ToString();
            string thana = Session["Thana"].ToString();
            string district = Session["District"].ToString();

            //string center = ViewState["center"].ToString();
            //string thana = ViewState["thana"].ToString();
            //string district = ViewState["district"].ToString();

            aDoctorEntry.Name = nameTextBox.Text;
            aDoctorEntry.Degeree = degreeTextBox.Text;
            aDoctorEntry.Specialization = specializationTextBox.Text;
            aDoctorEntry.CenterID = aDoctorEntryManager.GetIDBycenter(center);
            aDoctorEntry.ThanaID = aDoctorEntryManager.GetThanaIDBythana(thana);
            aDoctorEntry.DistrictID = aDoctorEntryManager.GetIDByDistrictName(district);

            showLabel.Text = aDoctorEntryManager.SaveDoctor(aDoctorEntry);
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