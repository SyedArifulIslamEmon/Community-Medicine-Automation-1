using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicineWebApp.BLL;

namespace CommunityMedicineWebApp.UI
{
    public partial class CenterLoginUI : System.Web.UI.Page
    {
        CenterCreateManager aCenterCreateManager = new CenterCreateManager();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string code = codeTextBox.Text;
            string password = passwordTextBox.Text;

            if (aCenterCreateManager.Login(code, password) > 0)
            {
                Session["Center"] = aCenterCreateManager.GetCenterByCode(code);
                Session["Thana"] = aCenterCreateManager.GetThanaByCode(code);
                Session["District"] = aCenterCreateManager.GetDistrictByCode(code);

                Response.Redirect("CenterMenu.aspx");
                codeTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else
            {
                showLabel.Text = "Username or Password not correct";
                codeTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }
    }
}