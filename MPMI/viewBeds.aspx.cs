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
    public partial class viewBeds : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
                //using (SqlConnection con = new SqlConnection(strcon))
                //{
                //    SqlCommand cmd = new SqlCommand("SELECT * from rooms where hospitalId=5", con);
                //    if (con.State == ConnectionState.Closed)
                //    {
                //        con.Open();
                //    }
                //    DataList1.DataSource = cmd.ExecuteReader();
                //    DataList1.DataBind();
                //}
            try
            {
                
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //findDepHosID();
                SqlCommand cmd = new SqlCommand("SELECT * from rooms where hospitalId=5", con);
                //DataList1.DataBind();
                con.Close();
                //Response.Write("<script>alert('added Successful.')</script>");
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('failed." + ex.Message + "')</script>");
            }


        }

        //protected void TimerTick(object sender, EventArgs e)
        //{
        //    BindRepeater();
        //    //lblTime.Text = "Last Refreshed: " + DateTime.Now.ToString();


        //}
        //protected void BindRepeater()
        //{
        //    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
        //    {


        //        string q = "select * from rooms Where hospitalId=5";
        //        SqlCommand cmd = new SqlCommand(q, con);
        //        //cmd.Parameters.AddWithValue("@p1", );

        //        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //        {
        //            DataTable dt = new DataTable();
        //            sda.Fill(dt);
        //            // Repeater1.DataSource = dt;
        //            // Repeater1.DataBind();

        //            DataList1.DataSource = dt;
        //            DataList1.DataBind();
        //        }

        //    }
        //}

        //protected void OnItemDataBound(object sender, DataListItemEventArgs e)
        //{

        //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        //    {
        //        //Reference the Repeater Item.
        //        DataListItem item = e.Item;

        //        //Reference the Controls.
        //        string status = (item.FindControl("Label2") as Label).Text;

        //        Image i = (item.FindControl("Image12") as Image);
        //        if (status == "v")
        //        {
        //            i.ImageUrl = "imgs/green.png";
        //        }


        //        if (status == "a")
        //        {
        //            i.ImageUrl = "imgs/red.png";
        //        }

        //    }
        //}
    }
}