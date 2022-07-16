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
    public partial class addNurse : System.Web.UI.Page
    {
        string doc_user = "";
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string encrypwd;
        string DepId = "", HosId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Response.Redirect("homepage.aspx");
            }
            else
            {
                var randomNumber = RandomNumber(5, 10000);
                doc_user = "nur" + randomNumber.ToString();
                //Console.WriteLine($"Random number between 5 and 100 is {randomNumber}");
                GridView1.DataBind();
            }
        }
        // Instantiate random number generator.  
        private readonly Random _random = new Random();
        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                encryption1();
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //findDepHosID();
                SqlCommand cmd = new SqlCommand("SELECT departmentId FROM departments where departmentName = '" + DropDownList1.SelectedItem.Value + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        DepId = row["departmentId"].ToString();
                    }
                    //DepId = dtLoginTable.Rows[0]["UserName"].ToString();
                }
                else
                {
                    //do nothing
                }
                cmd = new SqlCommand("SELECT hospitalId FROM hospitals where hospitalName = '" + DropDownList2.SelectedItem.Value + "'", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        HosId = row["hospitalId"].ToString();
                    }
                }
                else
                {
                    //do nothing
                }

                cmd = new SqlCommand("INSERT INTO doctors(docUser,docName,departmentId,hospitalId,password,role) VALUES (@docuser,@docname,@docdep,@dochos,@pass,@role)", con);
                cmd.Parameters.AddWithValue("@docuser", doc_user);
                cmd.Parameters.AddWithValue("@docname", TextBox1.Text.Trim());
                
                cmd.Parameters.AddWithValue("@docdep", Int32.Parse(DepId));
                cmd.Parameters.AddWithValue("@dochos", Int32.Parse(HosId));
                
                

                
                cmd.Parameters.AddWithValue("@pass", encrypwd);
                cmd.Parameters.AddWithValue("@role", "N");
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
        // Get selected items Using List and String.Join method
        
        public void encryption1()
        {
            encrypwd = string.Empty;
            byte[] encode = new byte[TextBox4.Text.ToString().Length];
            encode = Encoding.UTF8.GetBytes(TextBox4.Text);
            encrypwd = Convert.ToBase64String(encode);

        }


        //to clear form details
        void clearForm()
        {
            TextBox1.Text = "";
            TextBox4.Text = "";
            TextBox9.Text = "";
        }

        //delete doctor
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (check_doctor())
            {
                deleteDoctor();
            }
            else
            {
                Response.Write("<script>alert('not exist')</script>");
                //Response.Write("<script>alert('department doesn't exists exist')</script>");
            }
        }
        bool check_doctor()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT docId FROM doctors where docId = '" + TextBox9.Text.Trim() + "'", con);
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
        void deleteDoctor()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM doctors WHERE docId = '" + TextBox9.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Deleted Successful.')</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('failed.')</script>" + ex.Message);
            }
        }
    }
}