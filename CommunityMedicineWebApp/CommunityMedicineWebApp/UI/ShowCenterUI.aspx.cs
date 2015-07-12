using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommunityMedicineWebApp.UI
{
    public partial class ShowCenterUI : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null && Session["Code"] != null && Session["Password"] != null)
            {
                nameLabel.Text = Session["Name"].ToString();
                codeLabel.Text = Session["Code"].ToString();
                passwordLabel.Text = Session["Password"].ToString();
            }
        }
    }
}