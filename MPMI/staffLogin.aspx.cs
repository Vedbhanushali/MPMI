using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace MPMI
{
    public partial class staffLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string encrypwd = "",DorN="";
        protected void Page_Load(object sender, EventArgs e)
        {
            //this is if pressed back button from staff pages
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            encryption1();
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM doctors where docUser='"+TextBox1.Text.Trim()+"' AND password='" + encrypwd + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('" + dr.GetValue(0) + "')</script>");
                        Session["username"] = dr.GetValue(2).ToString();
                        Session["role"] = "staff";
                        Session["hospitalId"] = dr.GetValue(5).ToString();
                        DorN = dr.GetValue(9).ToString();
                    }
                    if (DorN.Equals("D"))
                    {
                        Response.Redirect("doctorAppointment.aspx");
                    }  else if (DorN.Equals("N"))
                    {   

                        Response.Redirect("nursePanel.aspx");
                    }
                    //Response.Redirect("adminPanel.aspx");
                }
                else
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
        public void encryption1()
        {
            encrypwd = string.Empty;
            byte[] encode = new byte[TextBox2.Text.ToString().Length];
            encode = Encoding.UTF8.GetBytes(TextBox2.Text);
            encrypwd = Convert.ToBase64String(encode);

        }
    }
}