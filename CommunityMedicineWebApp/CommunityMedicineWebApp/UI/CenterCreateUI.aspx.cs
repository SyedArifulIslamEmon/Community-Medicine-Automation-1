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
    public partial class CenterCreateUI : System.Web.UI.Page
    {
        DistrictManager aDistrictManager = new DistrictManager();
        CenterCreateManager aCenterCreateManager = new CenterCreateManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                districtDropDownList.DataSource = aDistrictManager.LoadAllDistrict();
                districtDropDownList.DataTextField = "DistrictName";
                districtDropDownList.DataValueField = "ID";
                districtDropDownList.DataBind();
            }
            
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            CenterCreate aCenterCreate = new CenterCreate();
            ShowCenterUI aShowCenterUi = new ShowCenterUI();

            aCenterCreate.Name = centerNameTextBox.Text;
            string thana = thanaDropDownList.SelectedItem.ToString();
            aCenterCreate.ThanaID = aCenterCreateManager.GetIDByThanaName(thana);
            aCenterCreate.DistrictID = aCenterCreateManager.GetDistrictIDByThanaName(thana);
            aCenterCreate.Code = GenerateCode(thana);
            aCenterCreate.Password = CreateRandomPassword();

            if (aCenterCreate.Name != "")
            {
                showLabel.Text = aCenterCreateManager.Save(aCenterCreate);
                Session["Name"] = centerNameTextBox.Text;
                Session["Code"] = aCenterCreate.Code;
                Session["Password"] = aCenterCreate.Password;
                Response.Redirect("ShowCenterUI.aspx");
            }
            else
            {
                showLabel.Text = "Not saved. Please enter information correctly.";
            }
            
        }

        public string GenerateCode(string thana)
        {
            Random random = new Random();
            return thana.Substring(0, 3) + random.Next(1, 9) + random.Next(1, 9) + random.Next(1, 9);
        }
        public string CreateRandomPassword()
        {
            int passwordLength = 6;
            string _allowedChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
            Random randNum = new Random();
            char[] chars = new char[passwordLength];
            int allowedCharCount = _allowedChars.Length;
            for (int i = 0; i < passwordLength; i++)
            {
                chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
            }
            return new string(chars);
        }

        protected void districtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string district = districtDropDownList.SelectedItem.ToString();
            thanaDropDownList.DataSource = aDistrictManager.LoadThana(district);
            thanaDropDownList.DataTextField = "ThanaName";
            thanaDropDownList.DataValueField = "ID";
            thanaDropDownList.DataBind();
        }
    }
}