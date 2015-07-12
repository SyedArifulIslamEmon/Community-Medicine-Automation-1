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
    public partial class SendMedicineUI : System.Web.UI.Page
    {
        DistrictManager aDistrictManager = new DistrictManager();
        MedicineQuantity aMedicineQuantity = new MedicineQuantity();
        CenterCreateManager aCenterCreateManager = new CenterCreateManager();
        MedicineManager aMedicineManager = new MedicineManager();

        private const string medicinelist = "medicinelist";

        public List<MedicineQuantity> medicineList
        {
            get
            {
                if (!(ViewState[medicinelist] is List<MedicineQuantity>))
                {
                    
                    ViewState[medicinelist] = new List<MedicineQuantity>();
                }

                return (List<MedicineQuantity>)ViewState[medicinelist];
            }
        }
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                districtDropDownList.DataSource = aDistrictManager.LoadAllDistrict();
                districtDropDownList.DataTextField = "DistrictName";
                districtDropDownList.DataValueField = "ID";
                districtDropDownList.DataBind();

                medicineDropDownList.DataSource = aMedicineManager.LoadAllMedicine();
                medicineDropDownList.DataTextField = "MedicineName";
                medicineDropDownList.DataValueField = "ID";
                medicineDropDownList.DataBind();
            }
            
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int districtID = int.Parse(districtDropDownList.SelectedValue);
            int thanaID = int.Parse(thanaDropDownList.SelectedValue);
            int centerID = int.Parse(centerDropDownList.SelectedValue);
            int currentQuantity = 0;

            aMedicineQuantity.Name = medicineDropDownList.SelectedItem.ToString();
            aMedicineQuantity.Quantity = int.Parse(quantityTextBox.Text);

            if (isThisMedicenExist(districtID, thanaID, centerID, aMedicineQuantity.Name))
            {
                int previousQuantity = aMedicineManager.PreviousQuantity(districtID, thanaID, centerID,
                    aMedicineQuantity.Name);
                currentQuantity = aMedicineQuantity.Quantity + previousQuantity;

                //aMedicineQuantity.Name = medicineDropDownList.SelectedItem.ToString();
                //aMedicineQuantity.Quantity = currentQuantity;
                //medicineList.Add(aMedicineQuantity);

                //medicineGridView.AutoGenerateColumns = true;
                //medicineGridView.DataSource = medicineList;
                //medicineGridView.DataBind();

                showLabel.Text = aMedicineManager.updateQuantity(districtID, thanaID, centerID, aMedicineQuantity.Name,
                    currentQuantity);
            }
            else
            {
                medicineList.Add(aMedicineQuantity);

                medicineGridView.AutoGenerateColumns = true;
                medicineGridView.DataSource = medicineList;
                medicineGridView.DataBind();
            }
            
        }

        public bool isThisMedicenExist(int districtID, int thanaID, int centerID, string medicineName)
        {
            return aMedicineManager.isThisMedicenExist(districtID, thanaID, centerID, medicineName);
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            int result = 0;

            foreach (MedicineQuantity medicineQuantity in medicineList)
            {
                SendMedicine aSendMedicine = new SendMedicine();

                string district = districtDropDownList.SelectedItem.ToString();
                aSendMedicine.DistrictID = aMedicineManager.GetIDByDistrictName(district);
                string thana = thanaDropDownList.SelectedItem.ToString();
                aSendMedicine.ThanaID = aMedicineManager.GetIDByThanaName(thana);
                string center = centerDropDownList.SelectedItem.ToString();
                aSendMedicine.CenterID = aMedicineManager.GetIDByCenterName(center);
                aSendMedicine.Medicine = medicineQuantity.Name;
                aSendMedicine.Quantity = int.Parse(medicineQuantity.Quantity.ToString());

                result = aMedicineManager.saveSendMedicine(aSendMedicine);
            }

            if (result != 0)
            {
                showLabel.Text = "Medicines added to center.";
            }
            else
            {
                showLabel.Text = "Medicines not added.";
            }
        }

        protected void districtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string district = districtDropDownList.SelectedItem.ToString();
            thanaDropDownList.DataSource = aDistrictManager.LoadThana(district);
            thanaDropDownList.DataTextField = "ThanaName";
            thanaDropDownList.DataValueField = "ID";
            thanaDropDownList.DataBind();
        }

        protected void thanaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thana = thanaDropDownList.SelectedItem.ToString();
            centerDropDownList.DataSource = aCenterCreateManager.CenterList(thana);
            centerDropDownList.DataTextField = "Name";
            centerDropDownList.DataValueField = "ID";
            centerDropDownList.DataBind();
        }
    }
}