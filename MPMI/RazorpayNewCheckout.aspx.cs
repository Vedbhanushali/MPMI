using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPMI
{
    public partial class RazorpayNewCheckout : System.Web.UI.Page
    {
        public string orderId;
        public string amount;
        public string contact;
        public string name;
        public string product;
        public string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            amount = (Convert.ToInt32(Request.QueryString["Amount"]) * 100).ToString();
            contact = Request.QueryString["Contact"].ToString();
            name = Request.QueryString["Name"].ToString();
            product = Request.QueryString["Doctor"].ToString();
            email = Request.QueryString["Email"].ToString();

            Dictionary<string, object> input = new Dictionary<string, object>();
            input.Add("amount", amount);
            input.Add("currency", "INR");
            input.Add("payment_capture", 1);

            string key = "paste your key of test or live mode";
            string secret = "paste your key of test or live mode";

            RazorpayClient client = new RazorpayClient(key, secret);

            Razorpay.Api.Order order = client.Order.Create(input);
            orderId = order["id"].ToString();
            //Response.Redirect("RazorpayCallback.aspx");
        }
    }
}