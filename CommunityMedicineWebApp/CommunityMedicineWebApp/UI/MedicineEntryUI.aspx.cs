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
    public partial class MedicineEntryUI : System.Web.UI.Page
    {
        Medicine aMedicine = new Medicine();
        MedicineManager aMedicineManager = new MedicineManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            medicineGridView.DataSource = aMedicineManager.LoadAllMedicine();
            medicineGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            aMedicine.MedicineName = medicineNameTextBox.Text;
            showLabel.Text = aMedicineManager.saveMedicine(aMedicine);
            //Response.Redirect(Request.RawUrl);
            medicineGridView.DataSource = aMedicineManager.LoadAllMedicine();
            medicineGridView.DataBind();
            
           
        }

        protected void medicineGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            medicineGridView.PageIndex = e.NewPageIndex;
            medicineGridView.DataSource = aMedicineManager.LoadAllMedicine();
            medicineGridView.DataBind();
        }
    }
}