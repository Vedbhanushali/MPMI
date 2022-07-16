using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPMI
{
    public partial class about : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"]==null)
            {
                //do nothing   
            } else
            {
                Response.Redirect("adminPanel.aspx");
            }
        }
    }
}