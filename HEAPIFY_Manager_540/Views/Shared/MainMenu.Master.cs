using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HEAPIFY_Manager_540.Views.Shared
{
    public partial class MainMenu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClinicalButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MedicalMasterPage.aspx");
        }
    }
}