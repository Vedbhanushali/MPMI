using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPMI
{
    public partial class RazorpayPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("RazorpayNewCheckout.aspx?Name={0}&Email={1}&Contact={2}&Doctor={3}&amount={4}",Textname.Text,Textemail.Text,Textnum.Text,Textdoc.Text,Textamount.Text));
        }
    }
}