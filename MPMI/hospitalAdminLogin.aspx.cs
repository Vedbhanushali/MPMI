using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPMI
{
    public partial class hospitalAdminLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            //Session["username"] = null;
            //Session["role"] = null;
            //Session.Abandon();
            //Session.Clear();

            //if (Session["role"].Equals("hospital_admin"))
            //{
            //    Response.Redirect("adminPanel.aspx");
            //}

            // this is for if back button is pressed from admin panel
            if (Session["role"] == null)
            {
                //do nothing
            } else
            {
                if (Session["role"].Equals("hospital_admin"))
                {
                    Response.Redirect("adminPanel.aspx");
                } else
                {
                    Response.Redirect("hospitalAdminLogin.aspx");
                }
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM admin_table where admin='"+TextBox1.Text.Trim()+"' AND password='"+TextBox2.Text.Trim()+"'",con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('"+dr.GetValue(0)+"')</script>");
                        Session["username"] = dr.GetValue(0).ToString();
                        Session["role"] = "hospital_admin";
                    }
                    Response.Redirect("adminPanel.aspx");
                } else
                {
                    Response.Write("<script>alert('Invalid credentials')</script>");
                }
                //con.Close();
                //Response.Write("<script>alert('Sign Up Successful.')</script>");
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('failed." + ex.Message + "')</script>");
            }


        }
    }
}