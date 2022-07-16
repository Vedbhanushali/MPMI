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
    public partial class addHospitals : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    Response.Redirect("homepage.aspx");
                }
                else
                {
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('failed'" + ex.Message + ")");
            }
        }

        //register hospital button
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (check_hospital())
            {
                Response.Write("<script>alert('hosptial already exist')</script>");
            }
            else
            {
                add_hospital();
            }
            //Response.Write("<script>alert('hosptial already exist')</script>");
        }

        void add_hospital()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO hospitals VALUES (@hos_name,@hos_add,@hos_ph)", con);
                cmd.Parameters.AddWithValue("hos_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("hos_ph", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("hos_add", TextBox5.Text.Trim() + ", " + TextBox6.Text.Trim() + ", " + TextBox7.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('added Successful.')</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('failed." + ex.Message + "')</script>");
            }
        }

        bool check_hospital()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT hospitalId FROM hospitals where hospitalName = '" + TextBox1.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    //Response.Write("<script>alert('true found')</script>");
                    return true;
                }
                else
                {
                    return false;
                }
                //con.Close();
                //Response.Write("<script>alert('Sign Up Successful.')</script>");
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('failed." + ex.Message + "')</script>");
                return false;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (check_hospitalID())
            {
                deleteHospital();
            }
            else
            {
                Response.Write("<script>alert('hosptial not exist')</script>");
            }
        }

        bool check_hospitalID()
        {
           
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT hospitalId FROM hospitals where hospitalId = '" + TextBox2.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    //Response.Write("<script>alert('true found')</script>");
                    return true;
                }
                else
                {
                    return false;
                }
                //con.Close();
                //Response.Write("<script>alert('Sign Up Successful.')</script>");
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('failed." + ex.Message + "')</script>");
                return false;
            }
        }
        void deleteHospital()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM hospitals WHERE hospitalId = '" + TextBox2.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Deleted Successful.')</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('failed.')</script>"+ex.Message);
            }
        }
        void clearForm()
        {
            TextBox1.Text = "";
        }
    }
}