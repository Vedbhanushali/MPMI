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
    public partial class addRooms : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string hospitalId = "",ward="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Response.Redirect("homepage.aspx");
            }
        }
        // Instantiate random number generator.  
        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
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
                //findDepHosID();
                SqlCommand cmd = new SqlCommand("SELECT hospitalId FROM hospitals where hospitalName = '" + DropDownList1.SelectedItem.Value + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        hospitalId = row["hospitalId"].ToString();
                    }
                    //DepId = dtLoginTable.Rows[0]["UserName"].ToString();
                }
                else
                {
                    //do nothing
                }
                //Response.Write("<script>alert('added S"+hospitalId+"uccessful.')</script>");

                cmd = new SqlCommand("INSERT INTO rooms(hospitalId,ward,bedStatus) VALUES (@hosId,@ward,@bedstat)", con);
                cmd.Parameters.AddWithValue("@hosId", Int32.Parse(hospitalId));
                if (RadioButtonList1.SelectedIndex != -1)
                {
                    GetCheckBoxListSelections();
                }
                else
                {
                    //no need to do
                    //lblSelectedValues.Text = "Please select any course";
                }
                //Response.Write("<script>alert('"+ward+"')</script>");
                cmd.Parameters.AddWithValue("@ward", ward);
                //different types of bed status
                /* vacant,admitted,maintanance,housekeeping,reserved*/
                cmd.Parameters.AddWithValue("@bedstat", "v");
                var rnd = new Random();
                
             
                //
                for (int i = 0; i < Int32.Parse(TextBox2.Text.Trim()); i++)
                {
                    
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                Response.Write("<script>alert('added Successful.')</script>");
                clearForm();
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('failed." + ex.Message + "')</script>");
            }
        }
        void clearForm()
        {
            
            TextBox2.Text = "";
            
        }
        private void GetCheckBoxListSelections()
        {

            //List<string> items = new List<string>();
            for (int i = 0; i < RadioButtonList1.Items.Count; i++)
            {
                if (RadioButtonList1.Items[i].Selected)
                {
                    //items.Add(CheckBoxList1.Items[i].Text);
                    ward = RadioButtonList1.Items[i].Text;
                    //if you want values instead of text then items.Add(cblCourses.Items[i].Value);
                }
                else
                {
                    //visitDay = visitDay + "0";
                }
            }
            //return String.Join(", ", items.ToArray());
            //return visitDay;
        }
    }
}