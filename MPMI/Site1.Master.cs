using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPMI
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //if (Session["role"].Equals(""))
                if(Session["role"]==null)
                {
                    LinkButton1.Visible = true; //staff login
                    LinkButton3.Visible = false; //logout
                    LinkButton7.Visible = false; //user profile
                    LinkButton6.Visible = true; //admin login
                }
                else if (Session["role"].Equals("staff"))
                {
                    LinkButton1.Visible = false; //staff login
                    LinkButton3.Visible = true; //logout
                    LinkButton7.Visible = true; //user profile
                    LinkButton7.Text = "Hello " + Session["username"].ToString();
                    LinkButton6.Visible = false; //admin login
                }
                else if (Session["role"].Equals("hospital_admin"))
                {
                    LinkButton1.Visible = false; //staff login
                    LinkButton3.Visible = true; //logout
                    LinkButton7.Visible = true; //user profile
                    LinkButton7.Text = "Hello " + Session["role"].ToString();
                    LinkButton6.Visible = false; //admin login
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('failed." + ex.Message + "')</script>");
            }
        }

        //hospital Admin login
        protected void BtnHospitalAdminLogin_click(object sender, EventArgs e)
        {
            //LinkButton6.Visible = false; //admin login
            Response.Redirect("hospitalAdminLogin.aspx");
        }

        //Staff login button
        protected void BtnStaffLogin_click(object sender, EventArgs e)
        {
            Response.Redirect("staffLogin.aspx");
        }

        //Logout button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["role"] = null;
            Session.Abandon();
            Session.Clear();
            LinkButton1.Visible = true; //staff login
            LinkButton3.Visible = false; //logout
            LinkButton7.Visible = false; //user profile
            LinkButton6.Visible = true; //admin login

            Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
            Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
            Response.AppendHeader("Expires", "0"); // Proxies.

            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewBeds.aspx");
        }
    }
}