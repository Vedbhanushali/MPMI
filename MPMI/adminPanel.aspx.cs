using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPMI
{
    public partial class admin_panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //if (Session["role"].Equals(""))
                if (Session["role"] == null)
                {
                    Response.Redirect("homepage.aspx");
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('failed." + ex.Message + "')</script>");
            }
        }

        //add department button
        protected void Button1_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("addDepartment.aspx");
            
            
        }


        // add hospital button
        protected void Button5_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("addHospitals.aspx");
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addDoctor.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("addNurse.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("addRooms.aspx");
        }
    }
}