using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPMI
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"]==null)
            {
                //Response.Redirect("adminPanel.aspx");
            } else
            {
                Response.Redirect("adminPanel.aspx");
            }
        }
    }
}