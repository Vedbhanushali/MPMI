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
    public partial class addDepartment : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Response.Redirect("homepage.aspx");
            } else
            {
                GridView1.DataBind();
            }
        }
        // add department
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (check_department())
            {
                Response.Write("<script>alert('department already exist')</script>");
            }
            else
            {
                add_department();
            }
            //Response.Write("<script>alert('failed')</script>");
        }

        

        void add_department()
        {
            //Response.Write("<script>alert('Sign Up Successful.')</script>");
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO departments(departmentName) VALUES (@departmentname)", con);
                cmd.Parameters.AddWithValue("@departmentname", TextBox1.Text.Trim());
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
            //Response.Write("<script>alert('executed')</script>");
        }

        
        //delete button
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (check_department())
            {
                deleteDepartment();
            }
            else
            {
                Response.Write("<script>alert('not exist')</script>");
                //Response.Write("<script>alert('department doesn't exists exist')</script>");
            }
        }

        void deleteDepartment()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM departments WHERE departmentName = '" + TextBox1.Text.Trim()+ "'", con);
                
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
        bool check_department()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT departmentId FROM departments where departmentName = '" + TextBox1.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
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

        //to clear form details
        void clearForm()
        {
            TextBox1.Text = "";
        }
    }
}